using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace ProiectPAW
{
    public partial class AdaugareRezervare : Form
    {
        public List<Rezervari> listRez = new List<Rezervari>();
        public AdaugareRezervare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (tbIdc.Text == "") errorProvider1.SetError(tbIdc, "Introduceti ID-ul clientului!");
            //else if (tbIdr.Text == "") errorProvider1.SetError(tbIdr, "Introduceti ID-ul rezervarii!");
            //else if (tbNrc.Text == "") errorProvider1.SetError(tbNrc, "Introduceti numarul camerei!");

            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Rezervari.accdb");
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                //comanda.CommandText = "SELECT MAX(idRezervare) FROM Rezervari";
                //int id = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO Rezervari VALUES (?,?,?,?,?)";
                comanda.Parameters.Add("idRezervare", OleDbType.Integer).Value = tbIdr.Text;
                comanda.Parameters.Add("nrCamera", OleDbType.Integer).Value = tbNrc.Text;
                comanda.Parameters.Add("idClient", OleDbType.Integer).Value = tbIdc.Text;
                comanda.Parameters.Add("DataInceput", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                comanda.Parameters.Add("DataSfarsit", OleDbType.Date).Value = dateTimePicker2.Value.Date;
                comanda.ExecuteNonQuery();
                MessageBox.Show("Rezervare adaugata cu succes!");

                int idR = Convert.ToInt32(tbIdr.Text);
                int idC = Convert.ToInt32(tbIdc.Text);
                int nrC = Convert.ToInt32(tbNrc.Text);
                DateTime d1 = dateTimePicker1.Value.Date;
                DateTime d2 = dateTimePicker2.Value.Date;

                Rezervari r = new Rezervari(idR, idC, nrC, d1, d2);


                if (Convert.ToInt32(tbNrc.Text) > 0 && Convert.ToInt32(tbNrc.Text) < 31) textBox4.Text = Convert.ToString(r.pretTotal(1));
                else if (Convert.ToInt32(tbNrc.Text) > 30 && Convert.ToInt32(tbNrc.Text) < 51) textBox4.Text = Convert.ToString(r.pretTotal(2));
                else if (Convert.ToInt32(tbNrc.Text) > 50 && Convert.ToInt32(tbNrc.Text) < 71) textBox4.Text = Convert.ToString(r.pretTotal(3));
                textBox2.Text = Convert.ToString(r.CalculeazaNrOre());
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Eroare");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare");
            }
            finally
            {
                conexiune.Close();
                tbIdc.Clear();
                tbNrc.Clear();
                tbIdr.Clear();
            }

            //try
            //{

            //    int idRezervare = Convert.ToInt32(tbIdr.Text);
            //    int idClient = Convert.ToInt32(tbIdc.Text);
            //    int numarCamera = Convert.ToInt32(tbNrc.Text);
            //    DateTime d1 = dateTimePicker1.Value.Date;
            //    DateTime d2 = dateTimePicker2.Value.Date;
            //    Rezervari r = new Rezervari(idRezervare, numarCamera, idClient, d1, d2);
            //if (Convert.ToInt32(tbNrc.Text) >= 1 && Convert.ToInt32(tbNrc.Text) <= 70)
            //{
            //    errorProvider1.Clear();
            //    listRez.Add(r);
            //    MessageBox.Show("Rezervarea a fost adaugata cu succes!");
            //    string filename = "Rezervari.txt";
            //    File.AppendAllText(filename, "\r\n" + r.IdRezervare + "," + r.NrCamera + "," + r.IdClient + "," + r.Luna + "," + r.NrZile + ",");
            //    for (int i = 0; i < r.NrZile; i++)
            //        File.AppendAllText(filename, zile[i] + ",");
            //    textBox2.Text = Convert.ToString(r.CalculeazaNrOre());
            //    if (Convert.ToInt32(tbNrc.Text) > 0 && Convert.ToInt32(tbNrc.Text) < 31) textBox4.Text = Convert.ToString(r.pretTotal(1));
            //    else if (Convert.ToInt32(tbNrc.Text) > 30 && Convert.ToInt32(tbNrc.Text) < 51) textBox4.Text = Convert.ToString(r.pretTotal(2));
            //    else if (Convert.ToInt32(tbNrc.Text) > 50 && Convert.ToInt32(tbNrc.Text) < 71) textBox4.Text = Convert.ToString(r.pretTotal(3));
            //}
            //else
            //{
            //    errorProvider1.SetError(tbNrc, "Introduceti un numar de camera existent!");
            //    MessageBox.Show("Camera nu exista...");
            //}


            //}

            //catch (Exception exc) { MessageBox.Show(exc.Message); }
            //finally
            //{
            //    tbIdc.Clear();

            //    tbIdr.Clear();
            //    tbNrc.Clear();


            //}




            /*  string line;
              List<Camera> listCamere = new List<Camera>();


              System.IO.StreamReader file =
                  new System.IO.StreamReader(@"Camere.txt");
              while ((line = file.ReadLine()) != null)
              {
                  string[] words = line.Split(',');
                  if (Convert.ToInt32(words[0]) == Convert.ToInt32(tbNrc.Text))
                      Convert.ToBoolean(words[2]) = false;

              }
              */




        }

        private void cbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string line;
            List<Camera> listCamere = new List<Camera>();


            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Camere.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                listCamere.Add(new Camera(Convert.ToInt32(words[0]), words[1], Convert.ToBoolean(words[2])));
            }

            file.Close();
            int[] words2 = new int[4];
            if (File.Exists(@"Preturi.txt"))
            {
                string firstLine = File.ReadLines("Preturi.txt").FirstOrDefault();
                words2[0] = Convert.ToInt32(firstLine.Split(' ')[0]);
                words2[1] = Convert.ToInt32(firstLine.Split(' ')[1]);
                words2[2] = Convert.ToInt32(firstLine.Split(' ')[2]);
            }
            foreach (Camera c in listCamere)
            {
                if (c.Disponibilitate == true)
                {
                    ListViewItem itm = new ListViewItem(c.NrCamera.ToString());
                    listView1.Columns[0].ListView.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Bold);
                    itm.Font = new Font(itm.Font, FontStyle.Regular);
                    itm.SubItems.Add(c.TipCamera);
                    itm.SubItems.Add(c.Disponibilitate.ToString());



                    if (c.TipCamera == "single")
                        itm.SubItems.Add(words2[0].ToString());
                    else if (c.TipCamera == "double")
                        itm.SubItems.Add(words2[1].ToString());
                    else if (c.TipCamera == "triple")
                        itm.SubItems.Add(words2[2].ToString());
                    listView1.Items.Add(itm);
        
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
          
            fa.ShowDialog();
            this.Close();
        }

        private void tbIdr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbIdc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbNrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbNrz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbZile_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox3.Text = "Adaugare - Shift + A\r\nCamere Disponibile - Shift + C\r\nRezervari existente - Shift + R\r\nMenu - Shift + M";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervariExistente fa = new RezervariExistente();
     
            fa.ShowDialog();
            this.Close();
        }

        private void tbNrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
       
            fa.ShowDialog();
            this.Close();
        }

        private void inchidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitForm fa = new exitForm();
            fa.ShowDialog();
        }

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true; 
            textBox3.Text = "Adaugare - Shift + A\r\nCamere Disponibile - Shift + C\r\nRezervari existente - Shift + R\r\nMenu - Shift + M";
        }

        private void angajatiCurentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareAngajati fa = new AfisareAngajati();
    
            fa.ShowDialog();
            this.Close();
        }

        private void adaugareAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareAngajat fa = new AdaugareAngajat();
     
            fa.ShowDialog();
            this.Close();
        }

        private void modificareSalariiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificareSalarii fa = new ModificareSalarii();

            fa.ShowDialog();
            this.Close();
        }

        private void clientiCurentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareClienti fa = new AfisareClienti();
 
            fa.ShowDialog();
            this.Close();
        }

        private void adaugareClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareClient fa = new AdaugareClient();
 
            fa.ShowDialog();
            this.Close();
        }

        private void afisareCamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareCamere fa = new AfisareCamere();
      
            fa.ShowDialog();
            this.Close();
        }

        private void rezervariCurenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervariExistente fa = new RezervariExistente();
    
            fa.ShowDialog();
            this.Close();
        }

        private void adaugareRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareRezervare fa = new AdaugareRezervare();
       
            fa.ShowDialog();
            this.Close();
        }

        private void încasăriLunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gf fa = new Gf();
         
            fa.ShowDialog();
            this.Close();
        }

        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

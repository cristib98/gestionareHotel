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
    public partial class RezervariExistente : Form
    {
        string con;
        public RezervariExistente()
        {
            InitializeComponent();
            con = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Rezervari.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            OleDbConnection conexiune = new OleDbConnection(con);
            listView1.Items.Clear();
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM Rezervari", conexiune);

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["idRezervare"].ToString());
                    itm.SubItems.Add(reader["NrCamera"].ToString());
                    itm.SubItems.Add(reader["IdClient"].ToString());
                    itm.SubItems.Add(reader["DataInceput"].ToString());
                    itm.SubItems.Add(reader["DataSfarsit"].ToString());
                    listView1.Items.Add(itm);
                    i++;
                }


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Eroare");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare");
            }
            finally
            {
                conexiune.Close();
            }

            textBox2.Text = Convert.ToString(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
      
            fa.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareRezervare fa = new AdaugareRezervare();
       
            fa.ShowDialog();
            this.Close();
        }

      

      

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                foreach (ListViewItem item in listView1.Items)
                {
                    sw.Write(item.Text);
                    sw.Write(" ");
                    for (int i = 1; i <= 4; i++)
                    {
                        sw.Write(item.SubItems[i].Text);
                        sw.Write(" ");
                    }
                    sw.WriteLine();
                }
                sw.Close();

            }
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
            textBox3.Text = "Afisare - Shift + A\r\nAdaugare - Shift + R\r\nNumar Rezervari - Shift + N\r\nSalvare - Shift + S\r\nMenu - Shift + M";
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
            Form1 fa = new Form1();
          
            fa.ShowDialog();
            this.Close();
        }
    }
}

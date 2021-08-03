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
namespace ProiectPAW
{
    public partial class AdaugareAngajat : Form
    {

       public List<Angajat> listAngajat = new List<Angajat>();

        public AdaugareAngajat()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {



            if (tbNume.Text == "") errorProvider1.SetError(tbNume, "Introduceti numele!");
            else if (tbPrenume.Text =="") errorProvider1.SetError(tbPrenume, "Introduceti prenumele!");
            else if (tbSalariu.Text=="") errorProvider1.SetError(tbSalariu, "Introduceti salariul!");
            else if (tbId.Text=="") errorProvider1.SetError(tbId, "Introduceti ID-ul!");
            else if (cbSex.Text=="") errorProvider1.SetError(cbSex, "Introduceti sexul!");
            try
            {
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                char sex = Convert.ToChar(cbSex.Text);
                int idAngajat = Convert.ToInt32(tbId.Text);
                float salariu = Convert.ToInt32(tbSalariu.Text);
                Angajat a = new Angajat(nume, prenume, sex, idAngajat, salariu);
                listAngajat.Add(a);
                MessageBox.Show("Angajatul a fost adaugat cu succes!");
                string filename = "Angajati.txt";
                File.AppendAllText(filename, "\r\n" + a.Nume + "," + a.Prenume + "," + a.Sex + "," + a.IdAngajat + "," + a.Salariu);

            }

            catch (Exception exc) { MessageBox.Show(exc.Message); }
            finally {
                tbId.Clear();
                cbSex.Text = "";
                tbNume.Clear();
                tbPrenume.Clear();
                tbSalariu.Clear();
            }
        }

        private void FormAngajati_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareAngajati fa = new AfisareAngajati();
        
            fa.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
         
            fa.ShowDialog();
            this.Close();
        }

        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void tbPrenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) && e.KeyChar != ' '&& e.KeyChar != '-')
                e.Handled = true;
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSalariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&e.KeyChar != '.')
                e.Handled = true;
        }

     

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void idkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitForm fa = new exitForm();
            fa.ShowDialog();
        }

        private void afisareAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareAngajati fa = new AfisareAngajati();
        
            fa.ShowDialog();
            this.Close();
        }

        private void meniuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
        
            fa.ShowDialog();
            this.Close();
        }

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Adaugare - Shift + A\r\nAfisare - Shift + F\r\nMenu - Shift + M";
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
    }
}

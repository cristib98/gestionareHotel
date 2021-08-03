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
    public partial class AdaugareClient : Form
    {

        public List<Client> listClient = new List<Client>();

        public AdaugareClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "") errorProvider1.SetError(tbNume, "Introduceti numele!");
            else if (tbPrenume.Text == "") errorProvider1.SetError(tbPrenume, "Introduceti prenumele!");
            else if (tbNationalitate.Text == "") errorProvider1.SetError(tbNationalitate, "Introduceti nationalitatea!");
            else if (tbNr.Text == "") errorProvider1.SetError(tbId, "Introduceti numarul de telefon!");
            else if (cbSex.Text == "") errorProvider1.SetError(cbSex, "Introduceti sexul!");
            else if (tbId.Text == "") errorProvider1.SetError(tbId, "Introduceti ID-ul!");
            try
            {
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                char sex = Convert.ToChar(cbSex.Text);
                int idClient = Convert.ToInt32(tbId.Text);
                string nationalitate = tbNationalitate.Text;
                string nrTelefon = tbNr.Text;
                Client c = new Client(nume, prenume, sex, idClient, nationalitate, nrTelefon);
                listClient.Add(c);
                MessageBox.Show("Clientul a fost adaugat cu succes!");
                string filename = "Clienti.txt";
                File.AppendAllText(filename, "\r\n"+c.Nume+","+c.Prenume + "," +c.Sex + "," +c.IdClient + "," +c.Nationalitate + "," +c.NrTelefon);
            }

            catch (Exception exc) { MessageBox.Show(exc.Message); }
            finally
            {
                tbId.Clear();
                cbSex.Text = "";
                tbNume.Clear();
                tbPrenume.Clear();
                tbNr.Clear();
                tbNationalitate.Clear();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareClienti fa = new AfisareClienti();
       
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
                !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
                e.Handled = true;
        }

        private void cbSex_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbNationalitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

      

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
            textBox1.Visible = true;
            textBox1.Text = "Adaugare - Shift + A\r\nAfisare Clienti - Shift + C\r\nMenu - Shift + M";
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

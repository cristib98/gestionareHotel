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
    public partial class AfisareAngajati : Form
    {
     
    
        public AfisareAngajati( )
        {
            InitializeComponent();
          
   
        }

        

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareAngajat fa = new AdaugareAngajat();
 
            fa.ShowDialog();
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string line;
            List<Angajat> listOfPersons = new List<Angajat>();

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Angajati.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                listOfPersons.Add(new Angajat(words[0], words[1], Convert.ToChar(words[2]), Convert.ToInt32(words[3]), Convert.ToSingle(words[4])));
            }

            file.Close();

            foreach (Angajat a in listOfPersons)
            {   
                ListViewItem itm = new ListViewItem(a.Nume);
                listView1.Columns[0].ListView.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Bold);
                itm.Font = new Font(itm.Font, FontStyle.Regular);
                itm.SubItems.Add(a.Prenume);
                itm.SubItems.Add(a.Sex.ToString());
                itm.SubItems.Add(a.IdAngajat.ToString());
                itm.SubItems.Add(a.Salariu.ToString());
                listView1.Items.Add(itm);
                
            }
            textBox2.Text = Convert.ToString(File.ReadLines("Angajati.txt").Count());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
       
            fa.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(File.ReadLines("Angajati.txt").Count());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox3.Text = "Citire - Shift + C\r\nAdaugare - Shift + A\r\nNumar total - Shift + N\r\nSalvare - Shift + S\r\nMenu - Shift + M";
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
            textBox3.Text = "Citire - Shift + C\r\nAdaugare - Shift + A\r\nNumar total - Shift + N\r\nSalvare - Shift + S\r\nMenu - Shift + M";
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

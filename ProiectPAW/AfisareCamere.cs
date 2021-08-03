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
    public partial class AfisareCamere : Form
    {
        public AfisareCamere()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
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
                i++;
            }
            textBox2.Text = Convert.ToString(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
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
                if (c.Disponibilitate == true) { 
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
                    i++;
                }
            }

            textBox2.Text = Convert.ToString(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
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
                if (c.Disponibilitate == false)
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
                    i++;
                }
            }

            textBox2.Text = Convert.ToString(i);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();

            fa.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
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
            int words2 = 0;
            if (File.Exists(@"Preturi.txt"))
            {
                string firstLine = File.ReadLines("Preturi.txt").FirstOrDefault();
                words2 = Convert.ToInt32(firstLine.Split(' ')[0]);
               
            }
            foreach (Camera c in listCamere)
            {
                if (c.TipCamera == "single")
                {
                    ListViewItem itm = new ListViewItem(c.NrCamera.ToString());
                    listView1.Columns[0].ListView.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Bold);
                    itm.Font = new Font(itm.Font, FontStyle.Regular);
                    itm.SubItems.Add(c.TipCamera);
                    itm.SubItems.Add(c.Disponibilitate.ToString());
                    itm.SubItems.Add(words2.ToString());
                    listView1.Items.Add(itm);
                    i++;
                }
            }

            textBox2.Text = Convert.ToString(i);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
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
            int words2 = 0;
            if (File.Exists(@"Preturi.txt"))
            {
                string firstLine = File.ReadLines("Preturi.txt").FirstOrDefault();
                words2 = Convert.ToInt32(firstLine.Split(' ')[1]);

            }
            foreach (Camera c in listCamere)
            {
                if (c.TipCamera == "double")
                {
                    ListViewItem itm = new ListViewItem(c.NrCamera.ToString());
                    listView1.Columns[0].ListView.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Bold);
                    itm.Font = new Font(itm.Font, FontStyle.Regular);
                    itm.SubItems.Add(c.TipCamera);
                    itm.SubItems.Add(c.Disponibilitate.ToString());
                    itm.SubItems.Add(words2.ToString());
                    listView1.Items.Add(itm);
                    i++;
                }
            }

            textBox2.Text = Convert.ToString(i);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 0;
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
            int words2 = 0;
            if (File.Exists(@"Preturi.txt"))
            {
                string firstLine = File.ReadLines("Preturi.txt").FirstOrDefault();
                words2 = Convert.ToInt32(firstLine.Split(' ')[2]);

            }
            foreach (Camera c in listCamere)
            {
                if (c.TipCamera == "triple")
                {
                    ListViewItem itm = new ListViewItem(c.NrCamera.ToString());
                    listView1.Columns[0].ListView.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Bold);
                    itm.Font = new Font(itm.Font, FontStyle.Regular);
                    itm.SubItems.Add(c.TipCamera);
                    itm.SubItems.Add(c.Disponibilitate.ToString());          
                    itm.SubItems.Add(words2.ToString());
                    listView1.Items.Add(itm);
                    i++;
                }
            }

            textBox2.Text = Convert.ToString(i);
        }

        private void button8_Click(object sender, EventArgs e)
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
                    for (int i = 1; i <= 3; i++)
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

        private void label1_Click(object sender, EventArgs e)
        {

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

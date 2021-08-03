using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class ModificareSalarii : Form
    {
        int x = 10;
        int y = 10;

        List<Angajat> listOfPersons = new List<Angajat>();
        public ModificareSalarii()
        {
            InitializeComponent();

            string line;
            


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
                listBox1.Items.Add(a.ToString());

            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;


        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, y);
            y += 20;
            if (y > panel1.Height)
            {
                MessageBox.Show("Cos plin!");
                panel1.Invalidate();
                y = 10;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            textBox3.Text += text + "\r\n";




        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd(panel2.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, x);
            x += 20;
            if (y > panel2.Height)
            {
                MessageBox.Show("Cos plin!");
                panel1.Invalidate();
                x = 10;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            textBox4.Text += text + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "") MessageBox.Show("Introduceti persoana/persoana care sa ii mariti salariul.");
            else if (textBox4.Text == "") MessageBox.Show("Introduceti persoana/persoana care sa ii scadeti salariul.");
            else if (textBox1.Text == "") MessageBox.Show("Introduceti suma cu care sa mariti salariul");
            else if (textBox2.Text == "") MessageBox.Show("Introduceti suma cu care sa micsorati salariul");
            else
            {


                string text = "";
                foreach (var item in listBox1.Items)
                {
                    text += item.ToString() + "\r\n";
                }
                textBox5.Text = text;
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.LastIndexOf(Environment.NewLine));


                File.WriteAllText("Angajati2.txt", String.Empty);
                foreach (string line in textBox5.Lines)
                {
                    string[] words;
                    words = line.Split(' ');
                    string filename = "Angajati2.txt";
                    File.AppendAllText(filename, words[4] + ",");
                    File.AppendAllText(filename, words[5]);
                    File.AppendAllText(filename, words[8] + ",");
                    File.AppendAllText(filename, words[2] + ",");
                    File.AppendAllText(filename, words[11] + "\r\n");
                }

                textBox3.Text = textBox3.Text.Remove(textBox3.Text.LastIndexOf(Environment.NewLine));

                File.WriteAllText("Angajati3.txt", String.Empty);
                foreach (string line in textBox3.Lines)
                {
                    string[] words;
                    words = line.Split(' ');
                    string filename = "Angajati3.txt";
                    File.AppendAllText(filename, words[4] + ",");
                    File.AppendAllText(filename, words[5]);
                    File.AppendAllText(filename, words[8] + ",");
                    File.AppendAllText(filename, words[2] + ",");
                    int p = Convert.ToInt32(words[11]);
                    int q = Convert.ToInt32(textBox1.Text);
                    p += q;
                    File.AppendAllText(filename, Convert.ToString(p) + "\r\n");
                }

                textBox4.Text = textBox4.Text.Remove(textBox4.Text.LastIndexOf(Environment.NewLine));

                File.WriteAllText("Angajati4.txt", String.Empty);
                foreach (string line in textBox4.Lines)
                {
                    string[] words;
                    words = line.Split(' ');
                    string filename = "Angajati4.txt";
                    File.AppendAllText(filename, words[4] + ",");
                    File.AppendAllText(filename, words[5]);
                    File.AppendAllText(filename, words[8] + ",");
                    File.AppendAllText(filename, words[2] + ",");
                    int l = Convert.ToInt32(words[11]);
                    int m = Convert.ToInt32(textBox2.Text);
                    l -= m;
                    File.AppendAllText(filename, Convert.ToString(l) + "\r\n");
                }

                File.WriteAllText("Angajati.txt", String.Empty);
                File.AppendAllText("Angajati.txt", File.ReadAllText("Angajati2.txt"));
                File.AppendAllText("Angajati.txt", File.ReadAllText("Angajati3.txt"));
                File.AppendAllText("Angajati.txt", File.ReadAllText("Angajati4.txt"));



                MessageBox.Show("Modificare realizată cu succes!");

                this.Hide();
                Form1 fa = new Form1();
                fa.StartPosition = FormStartPosition.Manual;
                fa.Location = this.Location;
                fa.Size = this.Size;
                fa.ShowDialog();
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
       
            fa.ShowDialog();
            this.Close();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

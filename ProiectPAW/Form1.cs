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
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            

            InitializeComponent();
            panelAngajati.Hide();
            panelClienti.Hide();
            panelCamere.Hide();
            panelRezervari.Hide();
            
            
        }

      
        private void hideS()
        {
            if (panelAngajati.Visible == true)
                panelAngajati.Visible = false;
            if (panelClienti.Visible == true)
                panelClienti.Visible = false;
            if (panelRezervari.Visible == true)
                panelRezervari.Visible = false;
            if (panelCamere.Visible == true)
                panelCamere.Visible = false;
        }
     

        private void customizeDesign()
        {
            panelAngajati.Visible = false;
            panelCamere.Visible = false;
            panelClienti.Visible = false;
            panelRezervari.Visible = false;
        }

       

        private void showS(Panel S)
        {
            if (S.Visible == false)
            {
                hideS();
                S.Visible = true;
            }

            else
                S.Visible = false;
        }

      
        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void camereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void rezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void angajatiCurentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareAngajati fa = new AfisareAngajati();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void adaugareAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareAngajat fa = new AdaugareAngajat();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void clientiCurentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareClienti fa = new AfisareClienti();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void adaugareClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareClient fa = new AdaugareClient();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void afisareCamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareCamere fa = new AfisareCamere();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void rezervariCurenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervariExistente fa = new RezervariExistente();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void adaugareRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareRezervare fa = new AdaugareRezervare();
            fa.StartPosition = FormStartPosition.Manual;
            fa.Location = this.Location;
            fa.Size = this.Size;
            fa.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void inchirereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitForm fa = new exitForm();
            fa.ShowDialog();
        }

      
        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(11, 29, 36);
            panelDetalii.BackColor = Color.FromArgb(11, 29, 36);
            label1.ForeColor = Color.FromArgb(153, 180, 209);
            label3.ForeColor = Color.FromArgb(160, 160, 160);
            panelLogo.BackColor = Color.FromArgb(11, 7, 17);
            button1.BackColor = Color.FromArgb(11, 7, 17);
            button5.BackColor = Color.FromArgb(11, 7, 17);
            button8.BackColor = Color.FromArgb(11, 7, 17);
            button9.BackColor = Color.FromArgb(11, 7, 17);
            button13.BackColor = Color.FromArgb(11, 7, 17);
            button14.BackColor = Color.FromArgb(11, 7, 17);
            button15.BackColor = Color.FromArgb(11, 7, 17);
            button16.BackColor = Color.FromArgb(11, 7, 17);
            panelMenu.BackColor = Color.FromArgb(11, 7, 17);
            button2.BackColor = Color.FromArgb(11, 29, 36);
            button3.BackColor = Color.FromArgb(11, 29, 36);
            button4.BackColor = Color.FromArgb(11, 29, 36);
            button6.BackColor = Color.FromArgb(11, 29, 36);
            button7.BackColor = Color.FromArgb(11, 29, 36);
            button10.BackColor = Color.FromArgb(11, 29, 36);
            button11.BackColor = Color.FromArgb(11, 29, 36);
            button12.BackColor = Color.FromArgb(11, 29, 36);
            panelMenu.BackColor = Color.FromArgb(11, 7, 17);
            button2.ForeColor = Color.FromArgb(220, 220, 220);
            button3.ForeColor = Color.FromArgb(220, 220, 220);
            button4.ForeColor = Color.FromArgb(220, 220, 220);
            button6.ForeColor = Color.FromArgb(220, 220, 220);
            button7.ForeColor = Color.FromArgb(220, 220, 220);
            button10.ForeColor = Color.FromArgb(220, 220, 220);
            button11.ForeColor = Color.FromArgb(220, 220, 220);
            button12.ForeColor = Color.FromArgb(220, 220, 220);


            label4.ForeColor = Color.FromArgb(160, 160, 160);
            label5.ForeColor = Color.FromArgb(160, 160, 160);
            label6.ForeColor = Color.FromArgb(160, 160, 160);
            label7.ForeColor = Color.FromArgb(160, 160, 160);
            label8.ForeColor = Color.FromArgb(160, 160, 160);
            label9.ForeColor = Color.FromArgb(160, 160, 160);
            label10.ForeColor = Color.FromArgb(160, 160, 160);
            label11.ForeColor = Color.FromArgb(160, 160, 160);
            label12.ForeColor = Color.FromArgb(160, 160, 160);
            label13.ForeColor = Color.FromArgb(160, 160, 160);
            label14.ForeColor = Color.FromArgb(160, 160, 160);
            label15.ForeColor = Color.FromArgb(160, 160, 160);
        }

        private void albastruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 230, 230);
            panelDetalii.BackColor = Color.FromArgb(230, 230, 230);
            label1.ForeColor = Color.FromArgb(138, 8, 0);
            label3.ForeColor = Color.FromArgb(138, 8, 0);
            panelLogo.BackColor = Color.FromArgb(39, 55, 74); 
            button1.BackColor = Color.FromArgb(39, 55, 74);
            button5.BackColor = Color.FromArgb(39, 55, 74);
            button8.BackColor = Color.FromArgb(39, 55, 74);
            button9.BackColor = Color.FromArgb(39, 55, 74);
            button13.BackColor = Color.FromArgb(39, 55, 74);
            button14.BackColor = Color.FromArgb(39, 55, 74);
            button15.BackColor = Color.FromArgb(39, 55, 74);
            button16.BackColor = Color.FromArgb(39, 55, 74);
            panelMenu.BackColor = Color.FromArgb(39, 55, 74);
            button2.BackColor = Color.FromArgb(230, 230, 230);
            button3.BackColor = Color.FromArgb(230, 230, 230);
            button4.BackColor = Color.FromArgb(230, 230, 230);
            button6.BackColor = Color.FromArgb(230, 230, 230);
            button7.BackColor = Color.FromArgb(230, 230, 230);
            button10.BackColor = Color.FromArgb(230, 230, 230);
            button11.BackColor = Color.FromArgb(230, 230, 230);
            button12.BackColor = Color.FromArgb(230, 230, 230);
            panelMenu.BackColor = Color.FromArgb(39, 55, 74);
            button2.ForeColor = Color.FromArgb(47, 62, 80);
            button3.ForeColor = Color.FromArgb(47, 62, 80);
            button4.ForeColor = Color.FromArgb(47, 62, 80);
            button6.ForeColor = Color.FromArgb(47, 62, 80);
            button7.ForeColor = Color.FromArgb(47, 62, 80);
            button10.ForeColor = Color.FromArgb(47, 62, 80);
            button11.ForeColor = Color.FromArgb(47, 62, 80);
            button12.ForeColor = Color.FromArgb(47, 62, 80);

           
            label4.ForeColor = Color.FromArgb(15, 20, 26);
            label5.ForeColor = Color.FromArgb(15, 20, 26);
            label6.ForeColor = Color.FromArgb(15, 20, 26);
            label7.ForeColor = Color.FromArgb(15, 20, 26);
            label8.ForeColor = Color.FromArgb(15, 20, 26);
            label9.ForeColor = Color.FromArgb(15, 20, 26);
            label10.ForeColor = Color.FromArgb(15, 20, 26);
            label11.ForeColor = Color.FromArgb(15, 20, 26);
            label12.ForeColor = Color.FromArgb(15, 20, 26);
            label13.ForeColor = Color.FromArgb(15, 20, 26);
            label14.ForeColor = Color.FromArgb(15, 20, 26);
            label15.ForeColor = Color.FromArgb(15, 20, 26);



        }

    

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"Preturi.txt"))
            {
                string firstLine = File.ReadLines("Preturi.txt").FirstOrDefault();
                textBox1.Text = firstLine.Split(' ')[0];
                textBox2.Text = firstLine.Split(' ')[1];
                textBox3.Text = firstLine.Split(' ')[2];
            }
            else
                textBox1.Text = "------------------";
        }

        private void încasăriLunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gf fa = new Gf();
          
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

        private void button1_Click(object sender, EventArgs e)
        {
            showS(panelAngajati);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            hideS();
            this.Hide();
            AfisareAngajati fa = new AfisareAngajati();
          
            fa.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideS();
            this.Hide();
            AdaugareAngajat fa = new AdaugareAngajat();
          
            fa.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificareSalarii fa = new ModificareSalarii();
           
            fa.ShowDialog();
            this.Close();
            hideS();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showS(panelClienti);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showS(panelCamere);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showS(panelRezervari);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareClienti fa = new AfisareClienti();
           
            fa.ShowDialog();
            this.Close();
            hideS();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareClient fa = new AdaugareClient();
           
            fa.ShowDialog();
            this.Close();
            hideS();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareCamere fa = new AfisareCamere();
         
            fa.ShowDialog();
            this.Close();
            hideS();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervariExistente fa = new RezervariExistente();
           
            fa.ShowDialog();
            this.Close();
            hideS();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareRezervare fa = new AdaugareRezervare();
           
            fa.ShowDialog();
            this.Close();
            hideS();
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            panelDetalii.Visible = true;
            button14.Visible = false;
            button15.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button14.Visible = true;
            panelDetalii.Visible = false;
            button15.Visible = false;
           
        }

        private void button13_Click(object sender, EventArgs e)
        {


            //Gf gf = new Gf() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.panel1.Controls.Add(gf);

            //gf.Show();
            //gf.FormBorderStyle = FormBorderStyle.None;
            //panel1.Visible = true;

            //button14.Visible = false;
            this.Hide();
            Gf fa = new Gf();
            
            fa.ShowDialog();
            this.Close();


        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            exitForm fa = new exitForm();
            fa.ShowDialog();

        }
    }
}

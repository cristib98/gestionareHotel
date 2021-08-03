using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Logare.accdb";
            string comanda = "Select Count(*) from Logare where NumeUtilizator=? and [Parola]=?";
            using (OleDbConnection con = new OleDbConnection(conString))
            using (OleDbCommand cmd = new OleDbCommand(comanda, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                int rez = (int)cmd.ExecuteScalar();
                if (rez > 0)
                {
                    this.Hide();
                    Form1 fa = new Form1();
                    fa.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username sau parola gresita!");
    
                    textBox2.Clear();
                }
            }





               
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exitForm fa = new exitForm();
            fa.ShowDialog();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}

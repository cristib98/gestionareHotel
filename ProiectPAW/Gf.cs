using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Gf : Form
    {
        public Gf()
        {
            InitializeComponent();
        }


       
        double[] vect = new double[200];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10;

        Color culoare = Color.FromArgb(93, 141, 255);
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        private void sumaPreturi() { }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 2 * marg,
                    panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
                Pen pen = new Pen(Color.FromArgb(11, 29, 36), 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                      (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                      (int)latime,
                      (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)), new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));
            }
        }

        private void Gf_Load(object sender, EventArgs e)
        {

            File.WriteAllText("IncasariLunare.txt", String.Empty);
            string line;
            List<Rezervari> listRezervari = new List<Rezervari>();
            int[] luni = new int[12];
            for (int i = 0; i < 12; i++)
            {
                luni[i] = 0;
            }

            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Rezervari.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM Rezervari", conexiune);
                using (OleDbDataReader reader = comanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rezervari r = new Rezervari();
                        r.IdRezervare = reader.GetInt32(0);
                        r.IdClient = reader.GetInt32(2);
                        r.NrCamera = reader.GetInt32(1);
                        r.CheckIn = reader.GetDateTime(3);
                        r.CheckOut = reader.GetDateTime(4);
                        listRezervari.Add(r);
                                           
                    }
                }

                foreach (Rezervari r in listRezervari)
                {
                    if (r.NrCamera > 0 && r.NrCamera < 31)
                    {
                        switch (r.CheckIn.Month)
                        {
                            case 1:
                                luni[0] += r.pretTotal(1);
                                break;
                            case 2:
                                luni[1] += r.pretTotal(1);
                                break;
                            case 3:
                                luni[2] += r.pretTotal(1);
                                break;
                            case 4:
                                luni[3] += r.pretTotal(1);
                                break;
                            case 5:
                                luni[4] += r.pretTotal(1);
                                break;
                            case 6:
                                luni[5] += r.pretTotal(1);
                                break;
                            case 7:
                                luni[6] += r.pretTotal(1);
                                break;
                            case 8:
                                luni[7] += r.pretTotal(1);
                                break;
                            case 9:
                                luni[8] += r.pretTotal(1);
                                break;
                            case 10:
                                luni[9] += r.pretTotal(1);
                                break;
                            case 11:
                                luni[10] += r.pretTotal(1);
                                break;
                            case 12:
                                luni[11] += r.pretTotal(1);
                                break;


                        }
                    }
                    else if (r.NrCamera > 30 && r.NrCamera < 51)
                    {
                        switch (r.CheckIn.Month)
                        {
                            case 1:
                                luni[0] += r.pretTotal(1);
                                break;
                            case 2:
                                luni[1] += r.pretTotal(1);
                                break;
                            case 3:
                                luni[2] += r.pretTotal(1);
                                break;
                            case 4:
                                luni[3] += r.pretTotal(1);
                                break;
                            case 5:
                                luni[4] += r.pretTotal(1);
                                break;
                            case 6:
                                luni[5] += r.pretTotal(1);
                                break;
                            case 7:
                                luni[6] += r.pretTotal(1);
                                break;
                            case 8:
                                luni[7] += r.pretTotal(1);
                                break;
                            case 9:
                                luni[8] += r.pretTotal(1);
                                break;
                            case 10:
                                luni[9] += r.pretTotal(1);
                                break;
                            case 11:
                                luni[10] += r.pretTotal(1);
                                break;
                            case 12:
                                luni[11] += r.pretTotal(1);
                                break;


                        }
                    }
                    else if (r.NrCamera > 50 && r.NrCamera < 71)
                    {
                        switch (r.CheckIn.Month)
                        {
                            case 1:
                                luni[0] += r.pretTotal(1);
                                break;
                            case 2:
                                luni[1] += r.pretTotal(1);
                                break;
                            case 3:
                                luni[2] += r.pretTotal(1);
                                break;
                            case 4:
                                luni[3] += r.pretTotal(1);
                                break;
                            case 5:
                                luni[4] += r.pretTotal(1);
                                break;
                            case 6:
                                luni[5] += r.pretTotal(1);
                                break;
                            case 7:
                                luni[6] += r.pretTotal(1);
                                break;
                            case 8:
                                luni[7] += r.pretTotal(1);
                                break;
                            case 9:
                                luni[8] += r.pretTotal(1);
                                break;
                            case 10:
                                luni[9] += r.pretTotal(1);
                                break;
                            case 11:
                                luni[10] += r.pretTotal(1);
                                break;
                            case 12:
                                luni[11] += r.pretTotal(1);
                                break;


                        }
                    }
                   
                }

                string filename = "IncasariLunare.txt";
                for (int i = 0; i < 12; i++)
                {
                    File.AppendAllText(filename, Convert.ToString(luni[i]) + "\r\n");
               
                }
                StreamReader sr = new StreamReader("IncasariLunare.txt");
                string linie = null;
                while ((linie = sr.ReadLine()) != null)
                {
                    try
                    {
                        vect[nrElem] = Convert.ToDouble(linie);
                        nrElem++;
                        vb = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                sr.Close();
                panel1.Invalidate();

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

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void save(Control c, string name)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(name);
            img.Dispose();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            save(panel1, "Incasari.bmp");
            MessageBox.Show("Salvarea s-a realizat cu succes!");
        }



        private void printDoc(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + marg, e.PageBounds.Y + 2 * marg,
                    e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 3 * marg);
                Pen pen = new Pen(Color.FromArgb(11, 29, 36), 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                      (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                      (int)latime,
                      (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)), new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDoc);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 obj = (Form1)Application.OpenForms["Form1"];
           
            this.Hide();

            Form1 fa = new Form1();
          
            
            fa.ShowDialog();
           
            this.Close();

        }
    }
}

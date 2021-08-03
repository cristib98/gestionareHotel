namespace ProiectPAW
{
    partial class ModificareSalarii
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.angajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angajatiCurentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareAngajatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiCurentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareCamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariCurenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.încasăriLunareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(701, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mărire cu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(696, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reducere cu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(700, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(700, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(371, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Efectuare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(618, 88);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(182, 125);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(633, 88);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(155, 93);
            this.textBox4.TabIndex = 9;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(658, 88);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(115, 90);
            this.textBox5.TabIndex = 10;
            this.textBox5.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(651, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Meniu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angajatiToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.camereToolStripMenuItem1,
            this.rezervariToolStripMenuItem,
            this.încasăriLunareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // angajatiToolStripMenuItem
            // 
            this.angajatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angajatiCurentiToolStripMenuItem,
            this.adaugareAngajatToolStripMenuItem});
            this.angajatiToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.angajatiToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.angajatiToolStripMenuItem.Name = "angajatiToolStripMenuItem";
            this.angajatiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.angajatiToolStripMenuItem.Text = "Angajați";
            // 
            // angajatiCurentiToolStripMenuItem
            // 
            this.angajatiCurentiToolStripMenuItem.Name = "angajatiCurentiToolStripMenuItem";
            this.angajatiCurentiToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.angajatiCurentiToolStripMenuItem.Text = "Angajați Curenți";
            this.angajatiCurentiToolStripMenuItem.Click += new System.EventHandler(this.angajatiCurentiToolStripMenuItem_Click);
            // 
            // adaugareAngajatToolStripMenuItem
            // 
            this.adaugareAngajatToolStripMenuItem.Name = "adaugareAngajatToolStripMenuItem";
            this.adaugareAngajatToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.adaugareAngajatToolStripMenuItem.Text = "Adăugare Angajat";
            this.adaugareAngajatToolStripMenuItem.Click += new System.EventHandler(this.adaugareAngajatToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiCurentiToolStripMenuItem,
            this.adaugareClientToolStripMenuItem});
            this.clientiToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.clientiToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.clientiToolStripMenuItem.Text = "Clienți";
            // 
            // clientiCurentiToolStripMenuItem
            // 
            this.clientiCurentiToolStripMenuItem.Name = "clientiCurentiToolStripMenuItem";
            this.clientiCurentiToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.clientiCurentiToolStripMenuItem.Text = "Clienți Curenți";
            this.clientiCurentiToolStripMenuItem.Click += new System.EventHandler(this.clientiCurentiToolStripMenuItem_Click);
            // 
            // adaugareClientToolStripMenuItem
            // 
            this.adaugareClientToolStripMenuItem.Name = "adaugareClientToolStripMenuItem";
            this.adaugareClientToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.adaugareClientToolStripMenuItem.Text = "Adăugare Client";
            this.adaugareClientToolStripMenuItem.Click += new System.EventHandler(this.adaugareClientToolStripMenuItem_Click);
            // 
            // camereToolStripMenuItem1
            // 
            this.camereToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareCamerToolStripMenuItem});
            this.camereToolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.camereToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.camereToolStripMenuItem1.Name = "camereToolStripMenuItem1";
            this.camereToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.camereToolStripMenuItem1.Text = "Camere";
            // 
            // afisareCamerToolStripMenuItem
            // 
            this.afisareCamerToolStripMenuItem.Name = "afisareCamerToolStripMenuItem";
            this.afisareCamerToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.afisareCamerToolStripMenuItem.Text = "Afișare Camere";
            this.afisareCamerToolStripMenuItem.Click += new System.EventHandler(this.afisareCamerToolStripMenuItem_Click);
            // 
            // rezervariToolStripMenuItem
            // 
            this.rezervariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervariCurenteToolStripMenuItem,
            this.adaugareRezervareToolStripMenuItem});
            this.rezervariToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.rezervariToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.rezervariToolStripMenuItem.Name = "rezervariToolStripMenuItem";
            this.rezervariToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.rezervariToolStripMenuItem.Text = "Rezervări";
            // 
            // rezervariCurenteToolStripMenuItem
            // 
            this.rezervariCurenteToolStripMenuItem.Name = "rezervariCurenteToolStripMenuItem";
            this.rezervariCurenteToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.rezervariCurenteToolStripMenuItem.Text = "Rezervări Curente";
            this.rezervariCurenteToolStripMenuItem.Click += new System.EventHandler(this.rezervariCurenteToolStripMenuItem_Click);
            // 
            // adaugareRezervareToolStripMenuItem
            // 
            this.adaugareRezervareToolStripMenuItem.Name = "adaugareRezervareToolStripMenuItem";
            this.adaugareRezervareToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.adaugareRezervareToolStripMenuItem.Text = "Adăugare Rezervare";
            this.adaugareRezervareToolStripMenuItem.Click += new System.EventHandler(this.adaugareRezervareToolStripMenuItem_Click);
            // 
            // încasăriLunareToolStripMenuItem
            // 
            this.încasăriLunareToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.încasăriLunareToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.încasăriLunareToolStripMenuItem.Name = "încasăriLunareToolStripMenuItem";
            this.încasăriLunareToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.încasăriLunareToolStripMenuItem.Text = "Încasări Lunare";
            this.încasăriLunareToolStripMenuItem.Click += new System.EventHandler(this.încasăriLunareToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackgroundImage = global::ProiectPAW.Properties.Resources.miuns;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(371, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 174);
            this.panel2.TabIndex = 2;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::ProiectPAW.Properties.Resources.plus;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(371, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 167);
            this.panel1.TabIndex = 1;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // ModificareSalarii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "ModificareSalarii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificareSalarii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem angajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angajatiCurentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareAngajatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiCurentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afisareCamerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariCurenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem încasăriLunareToolStripMenuItem;
    }
}
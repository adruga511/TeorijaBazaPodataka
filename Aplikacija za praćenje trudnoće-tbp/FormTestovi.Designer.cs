namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    partial class FormTestovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestovi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.cboTestovi = new System.Windows.Forms.ComboBox();
            this.dtpTestovi = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxTestovi = new System.Windows.Forms.RichTextBox();
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.pictureTest = new System.Windows.Forms.PictureBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 606);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(213, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(421, 26);
            this.labelDnevnik.TabIndex = 4;
            this.labelDnevnik.Text = "Ovdje možete unijeti obavljene testove";
            // 
            // cboTestovi
            // 
            this.cboTestovi.FormattingEnabled = true;
            this.cboTestovi.Location = new System.Drawing.Point(35, 134);
            this.cboTestovi.Name = "cboTestovi";
            this.cboTestovi.Size = new System.Drawing.Size(243, 24);
            this.cboTestovi.TabIndex = 5;
            // 
            // dtpTestovi
            // 
            this.dtpTestovi.Location = new System.Drawing.Point(35, 300);
            this.dtpTestovi.Name = "dtpTestovi";
            this.dtpTestovi.Size = new System.Drawing.Size(200, 22);
            this.dtpTestovi.TabIndex = 11;
            // 
            // richTextBoxTestovi
            // 
            this.richTextBoxTestovi.Location = new System.Drawing.Point(35, 178);
            this.richTextBoxTestovi.Name = "richTextBoxTestovi";
            this.richTextBoxTestovi.Size = new System.Drawing.Size(243, 96);
            this.richTextBoxTestovi.TabIndex = 12;
            this.richTextBoxTestovi.Text = "";
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestovi.Location = new System.Drawing.Point(346, 178);
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.RowHeadersWidth = 51;
            this.dgvTestovi.RowTemplate.Height = 24;
            this.dgvTestovi.Size = new System.Drawing.Size(485, 244);
            this.dgvTestovi.TabIndex = 13;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDodaj.Location = new System.Drawing.Point(452, 540);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 39);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.PeachPuff;
            this.btnObrisi.Location = new System.Drawing.Point(546, 540);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 39);
            this.btnObrisi.TabIndex = 15;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPovratak.Location = new System.Drawing.Point(640, 540);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(88, 39);
            this.btnPovratak.TabIndex = 16;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUcitajSliku.Location = new System.Drawing.Point(35, 540);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(88, 39);
            this.btnUcitajSliku.TabIndex = 17;
            this.btnUcitajSliku.Text = "Učitaj sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = false;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // pictureTest
            // 
            this.pictureTest.Location = new System.Drawing.Point(35, 362);
            this.pictureTest.Name = "pictureTest";
            this.pictureTest.Size = new System.Drawing.Size(243, 157);
            this.pictureTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTest.TabIndex = 18;
            this.pictureTest.TabStop = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPrikazi.Location = new System.Drawing.Point(743, 428);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(88, 39);
            this.btnPrikazi.TabIndex = 19;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prikaz testova";
            // 
            // FormTestovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.pictureTest);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvTestovi);
            this.Controls.Add(this.richTextBoxTestovi);
            this.Controls.Add(this.dtpTestovi);
            this.Controls.Add(this.cboTestovi);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTestovi";
            this.Text = "FormTestovi";
            this.Load += new System.EventHandler(this.FormTestovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.ComboBox cboTestovi;
        private System.Windows.Forms.DateTimePicker dtpTestovi;
        private System.Windows.Forms.RichTextBox richTextBoxTestovi;
        private System.Windows.Forms.DataGridView dgvTestovi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.PictureBox pictureTest;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
    }
}
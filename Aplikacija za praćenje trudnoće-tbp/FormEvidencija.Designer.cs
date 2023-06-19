namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    partial class FormEvidencija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvidencija));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojOtkucajaSrca = new System.Windows.Forms.TextBox();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.dtpEvidencija = new System.Windows.Forms.DateTimePicker();
            this.dgvEvidencija = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(56, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(523, 26);
            this.labelDnevnik.TabIndex = 4;
            this.labelDnevnik.Text = "Ovdje možete evidentirati težinu i otkucaje srca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Broj otkucaja srca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Težina u kg";
            // 
            // txtBrojOtkucajaSrca
            // 
            this.txtBrojOtkucajaSrca.Location = new System.Drawing.Point(45, 111);
            this.txtBrojOtkucajaSrca.Name = "txtBrojOtkucajaSrca";
            this.txtBrojOtkucajaSrca.Size = new System.Drawing.Size(161, 22);
            this.txtBrojOtkucajaSrca.TabIndex = 16;
            // 
            // txtTezina
            // 
            this.txtTezina.Location = new System.Drawing.Point(45, 180);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(161, 22);
            this.txtTezina.TabIndex = 17;
            // 
            // dtpEvidencija
            // 
            this.dtpEvidencija.Location = new System.Drawing.Point(45, 229);
            this.dtpEvidencija.Name = "dtpEvidencija";
            this.dtpEvidencija.Size = new System.Drawing.Size(200, 22);
            this.dtpEvidencija.TabIndex = 18;
            // 
            // dgvEvidencija
            // 
            this.dgvEvidencija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencija.Location = new System.Drawing.Point(301, 143);
            this.dgvEvidencija.Name = "dgvEvidencija";
            this.dgvEvidencija.RowHeadersWidth = 51;
            this.dgvEvidencija.RowTemplate.Height = 24;
            this.dgvEvidencija.Size = new System.Drawing.Size(348, 166);
            this.dgvEvidencija.TabIndex = 19;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSpremi.Location = new System.Drawing.Point(61, 377);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 39);
            this.btnSpremi.TabIndex = 23;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.Color.PeachPuff;
            this.btnObriši.Location = new System.Drawing.Point(166, 377);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(88, 39);
            this.btnObriši.TabIndex = 24;
            this.btnObriši.Text = "Obrisi";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPovratak.Location = new System.Drawing.Point(551, 377);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(88, 39);
            this.btnPovratak.TabIndex = 25;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIzmijeni.Location = new System.Drawing.Point(561, 94);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(88, 39);
            this.btnIzmijeni.TabIndex = 26;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // FormEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvEvidencija);
            this.Controls.Add(this.dtpEvidencija);
            this.Controls.Add(this.txtTezina);
            this.Controls.Add(this.txtBrojOtkucajaSrca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEvidencija";
            this.Text = "FormEvidencija";
            this.Load += new System.EventHandler(this.FormEvidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojOtkucajaSrca;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.DateTimePicker dtpEvidencija;
        private System.Windows.Forms.DataGridView dgvEvidencija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzmijeni;
    }
}
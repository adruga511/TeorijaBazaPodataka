namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    partial class FormSmetnje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSmetnje));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSmetnje = new System.Windows.Forms.DataGridView();
            this.dtpSmetnja = new System.Windows.Forms.DateTimePicker();
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.cboSmetnje = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmetnje)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSmetnje
            // 
            this.dgvSmetnje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmetnje.Location = new System.Drawing.Point(299, 153);
            this.dgvSmetnje.Name = "dgvSmetnje";
            this.dgvSmetnje.RowHeadersWidth = 51;
            this.dgvSmetnje.RowTemplate.Height = 24;
            this.dgvSmetnje.Size = new System.Drawing.Size(344, 212);
            this.dgvSmetnje.TabIndex = 1;
            // 
            // dtpSmetnja
            // 
            this.dtpSmetnja.Location = new System.Drawing.Point(22, 196);
            this.dtpSmetnja.Name = "dtpSmetnja";
            this.dtpSmetnja.Size = new System.Drawing.Size(200, 22);
            this.dtpSmetnja.TabIndex = 2;
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(104, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(463, 26);
            this.labelDnevnik.TabIndex = 3;
            this.labelDnevnik.Text = "Ovdje možete unijeti smetnje tijekom dana";
            // 
            // cboSmetnje
            // 
            this.cboSmetnje.FormattingEnabled = true;
            this.cboSmetnje.Location = new System.Drawing.Point(22, 153);
            this.cboSmetnje.Name = "cboSmetnje";
            this.cboSmetnje.Size = new System.Drawing.Size(243, 24);
            this.cboSmetnje.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDodaj.Location = new System.Drawing.Point(32, 385);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 39);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.PeachPuff;
            this.btnObrisi.Location = new System.Drawing.Point(144, 385);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 39);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPovratak.Location = new System.Drawing.Point(255, 385);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(88, 39);
            this.btnPovratak.TabIndex = 12;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prikaz smetnji";
            // 
            // FormSmetnje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cboSmetnje);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.dtpSmetnja);
            this.Controls.Add(this.dgvSmetnje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSmetnje";
            this.Text = "FormSmetnje";
            this.Load += new System.EventHandler(this.FormSmetnje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmetnje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSmetnje;
        private System.Windows.Forms.DateTimePicker dtpSmetnja;
        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.ComboBox cboSmetnje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label1;
    }
}
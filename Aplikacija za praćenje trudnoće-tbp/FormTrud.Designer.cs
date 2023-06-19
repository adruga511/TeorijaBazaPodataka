namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    partial class FormTrud
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrud));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.dgvTrudovi = new System.Windows.Forms.DataGridView();
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.btnPocetak = new System.Windows.Forms.Button();
            this.btnZavrsetak = new System.Windows.Forms.Button();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSekunde = new System.Windows.Forms.Label();
            this.lblMilisekunde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrudovi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(117, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(420, 26);
            this.labelDnevnik.TabIndex = 1;
            this.labelDnevnik.Text = "Ovdje možete zabilježiti trajanje truda";
            // 
            // dgvTrudovi
            // 
            this.dgvTrudovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrudovi.Location = new System.Drawing.Point(25, 273);
            this.dgvTrudovi.Name = "dgvTrudovi";
            this.dgvTrudovi.RowHeadersWidth = 51;
            this.dgvTrudovi.RowTemplate.Height = 24;
            this.dgvTrudovi.Size = new System.Drawing.Size(591, 150);
            this.dgvTrudovi.TabIndex = 2;
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonPovratak.Location = new System.Drawing.Point(570, 12);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(88, 39);
            this.buttonPovratak.TabIndex = 6;
            this.buttonPovratak.Text = "Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = false;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // btnPocetak
            // 
            this.btnPocetak.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPocetak.Location = new System.Drawing.Point(52, 176);
            this.btnPocetak.Name = "btnPocetak";
            this.btnPocetak.Size = new System.Drawing.Size(88, 39);
            this.btnPocetak.TabIndex = 7;
            this.btnPocetak.Text = "Početak";
            this.btnPocetak.UseVisualStyleBackColor = false;
            this.btnPocetak.Click += new System.EventHandler(this.btnPocetak_Click);
            // 
            // btnZavrsetak
            // 
            this.btnZavrsetak.BackColor = System.Drawing.Color.PeachPuff;
            this.btnZavrsetak.Location = new System.Drawing.Point(146, 176);
            this.btnZavrsetak.Name = "btnZavrsetak";
            this.btnZavrsetak.Size = new System.Drawing.Size(88, 39);
            this.btnZavrsetak.TabIndex = 8;
            this.btnZavrsetak.Text = "Završetak";
            this.btnZavrsetak.UseVisualStyleBackColor = false;
            this.btnZavrsetak.Click += new System.EventHandler(this.btnZavrsetak_Click);
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.BackColor = System.Drawing.Color.PeachPuff;
            this.lblMinute.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(24, 97);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(82, 56);
            this.lblMinute.TabIndex = 9;
            this.lblMinute.Text = "00";
            // 
            // lblSekunde
            // 
            this.lblSekunde.AutoSize = true;
            this.lblSekunde.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSekunde.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekunde.Location = new System.Drawing.Point(157, 97);
            this.lblSekunde.Name = "lblSekunde";
            this.lblSekunde.Size = new System.Drawing.Size(82, 56);
            this.lblSekunde.TabIndex = 10;
            this.lblSekunde.Text = "00";
            // 
            // lblMilisekunde
            // 
            this.lblMilisekunde.AutoSize = true;
            this.lblMilisekunde.BackColor = System.Drawing.Color.PeachPuff;
            this.lblMilisekunde.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisekunde.Location = new System.Drawing.Point(290, 97);
            this.lblMilisekunde.Name = "lblMilisekunde";
            this.lblMilisekunde.Size = new System.Drawing.Size(82, 56);
            this.lblMilisekunde.TabIndex = 11;
            this.lblMilisekunde.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 56);
            this.label3.TabIndex = 14;
            this.label3.Text = ":";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PeachPuff;
            this.btnReset.Location = new System.Drawing.Point(240, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 39);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.PeachPuff;
            this.btnObrisi.Location = new System.Drawing.Point(528, 228);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 39);
            this.btnObrisi.TabIndex = 16;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormTrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMilisekunde);
            this.Controls.Add(this.lblSekunde);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.btnZavrsetak);
            this.Controls.Add(this.btnPocetak);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.dgvTrudovi);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTrud";
            this.Text = "FormTrud";
            this.Load += new System.EventHandler(this.FormTrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrudovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.DataGridView dgvTrudovi;
        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.Button btnPocetak;
        private System.Windows.Forms.Button btnZavrsetak;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSekunde;
        private System.Windows.Forms.Label lblMilisekunde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnObrisi;
    }
}
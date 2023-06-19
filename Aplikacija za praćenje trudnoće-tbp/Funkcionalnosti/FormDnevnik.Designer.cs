namespace Aplikacija_za_praćenje_trudnoće_tbp.Funkcionalnosti
{
    partial class FormDnevnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDnevnik));
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.dgvDnevnik = new System.Windows.Forms.DataGridView();
            this.dtpDnevnik = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDnevnik = new System.Windows.Forms.RichTextBox();
            this.buttonDnevnik = new System.Windows.Forms.Button();
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(184, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(306, 26);
            this.labelDnevnik.TabIndex = 0;
            this.labelDnevnik.Text = "Ovdje možete pisati dnevnik";
            // 
            // dgvDnevnik
            // 
            this.dgvDnevnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDnevnik.Location = new System.Drawing.Point(43, 260);
            this.dgvDnevnik.Name = "dgvDnevnik";
            this.dgvDnevnik.RowHeadersWidth = 51;
            this.dgvDnevnik.RowTemplate.Height = 24;
            this.dgvDnevnik.Size = new System.Drawing.Size(339, 166);
            this.dgvDnevnik.TabIndex = 1;
            // 
            // dtpDnevnik
            // 
            this.dtpDnevnik.CalendarFont = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDnevnik.Location = new System.Drawing.Point(331, 90);
            this.dtpDnevnik.Name = "dtpDnevnik";
            this.dtpDnevnik.Size = new System.Drawing.Size(200, 22);
            this.dtpDnevnik.TabIndex = 2;
            // 
            // richTextBoxDnevnik
            // 
            this.richTextBoxDnevnik.Location = new System.Drawing.Point(43, 90);
            this.richTextBoxDnevnik.Name = "richTextBoxDnevnik";
            this.richTextBoxDnevnik.Size = new System.Drawing.Size(233, 150);
            this.richTextBoxDnevnik.TabIndex = 3;
            this.richTextBoxDnevnik.Text = "";
            // 
            // buttonDnevnik
            // 
            this.buttonDnevnik.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonDnevnik.Location = new System.Drawing.Point(331, 201);
            this.buttonDnevnik.Name = "buttonDnevnik";
            this.buttonDnevnik.Size = new System.Drawing.Size(88, 39);
            this.buttonDnevnik.TabIndex = 4;
            this.buttonDnevnik.Text = "Dodaj";
            this.buttonDnevnik.UseVisualStyleBackColor = false;
            this.buttonDnevnik.Click += new System.EventHandler(this.buttonDnevnik_Click);
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonPovratak.Location = new System.Drawing.Point(523, 387);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(88, 39);
            this.buttonPovratak.TabIndex = 5;
            this.buttonPovratak.Text = "Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = false;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(667, 449);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonIzbrisi.Location = new System.Drawing.Point(443, 201);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(88, 39);
            this.buttonIzbrisi.TabIndex = 8;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = false;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPrikazi.Location = new System.Drawing.Point(548, 201);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(88, 39);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // FormDnevnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.buttonDnevnik);
            this.Controls.Add(this.richTextBoxDnevnik);
            this.Controls.Add(this.dtpDnevnik);
            this.Controls.Add(this.dgvDnevnik);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormDnevnik";
            this.Text = "FormDnevnik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.DataGridView dgvDnevnik;
        private System.Windows.Forms.DateTimePicker dtpDnevnik;
        private System.Windows.Forms.RichTextBox richTextBoxDnevnik;
        private System.Windows.Forms.Button buttonDnevnik;
        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button btnPrikazi;
    }
}
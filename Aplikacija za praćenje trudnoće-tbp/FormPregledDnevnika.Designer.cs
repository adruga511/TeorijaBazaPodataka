namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    partial class FormPregledDnevnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledDnevnika));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBoxDnevnikPregled = new System.Windows.Forms.RichTextBox();
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBoxDnevnikPregled
            // 
            this.richTextBoxDnevnikPregled.Location = new System.Drawing.Point(54, 76);
            this.richTextBoxDnevnikPregled.Name = "richTextBoxDnevnikPregled";
            this.richTextBoxDnevnikPregled.Size = new System.Drawing.Size(338, 310);
            this.richTextBoxDnevnikPregled.TabIndex = 4;
            this.richTextBoxDnevnikPregled.Text = "";
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(95, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(439, 26);
            this.labelDnevnik.TabIndex = 6;
            this.labelDnevnik.Text = "Ovdje možete izmijeniti bilješku dnevnika";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIzmijeni.Location = new System.Drawing.Point(432, 385);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(88, 39);
            this.btnIzmijeni.TabIndex = 7;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // FormPregledDnevnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.richTextBoxDnevnikPregled);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPregledDnevnika";
            this.Text = "FormPregledDnevnika";
            this.Load += new System.EventHandler(this.FormPregledDnevnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDnevnikPregled;
        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.Button btnIzmijeni;
    }
}
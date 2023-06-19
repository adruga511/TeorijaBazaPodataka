namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    partial class FormPregledTesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledTesta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDnevnik = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumIVrijemeKreiranja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureTest = new System.Windows.Forms.PictureBox();
            this.richTextBoxTest = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDnevnik
            // 
            this.labelDnevnik.AutoSize = true;
            this.labelDnevnik.BackColor = System.Drawing.SystemColors.Control;
            this.labelDnevnik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnevnik.Location = new System.Drawing.Point(238, 9);
            this.labelDnevnik.Name = "labelDnevnik";
            this.labelDnevnik.Size = new System.Drawing.Size(152, 26);
            this.labelDnevnik.TabIndex = 5;
            this.labelDnevnik.Text = "Pregled testa";
            // 
            // txtTest
            // 
            this.txtTest.BackColor = System.Drawing.SystemColors.Window;
            this.txtTest.Location = new System.Drawing.Point(36, 96);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(238, 22);
            this.txtTest.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv testa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum i vrijeme kreiranja";
            // 
            // txtDatumIVrijemeKreiranja
            // 
            this.txtDatumIVrijemeKreiranja.BackColor = System.Drawing.SystemColors.Window;
            this.txtDatumIVrijemeKreiranja.Location = new System.Drawing.Point(36, 166);
            this.txtDatumIVrijemeKreiranja.Name = "txtDatumIVrijemeKreiranja";
            this.txtDatumIVrijemeKreiranja.Size = new System.Drawing.Size(238, 22);
            this.txtDatumIVrijemeKreiranja.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Opis";
            // 
            // pictureTest
            // 
            this.pictureTest.Location = new System.Drawing.Point(342, 71);
            this.pictureTest.Name = "pictureTest";
            this.pictureTest.Size = new System.Drawing.Size(291, 252);
            this.pictureTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTest.TabIndex = 18;
            this.pictureTest.TabStop = false;
            // 
            // richTextBoxTest
            // 
            this.richTextBoxTest.Location = new System.Drawing.Point(36, 248);
            this.richTextBoxTest.Name = "richTextBoxTest";
            this.richTextBoxTest.Size = new System.Drawing.Size(238, 96);
            this.richTextBoxTest.TabIndex = 19;
            this.richTextBoxTest.Text = "";
            // 
            // FormPregledTesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.richTextBoxTest);
            this.Controls.Add(this.pictureTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatumIVrijemeKreiranja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.labelDnevnik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPregledTesta";
            this.Text = "FormPregledTesta";
            this.Load += new System.EventHandler(this.FormPregledTesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDnevnik;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatumIVrijemeKreiranja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureTest;
        private System.Windows.Forms.RichTextBox richTextBoxTest;
    }
}
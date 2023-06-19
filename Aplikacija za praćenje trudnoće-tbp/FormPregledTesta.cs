using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;
using Aplikacija_za_praćenje_trudnoće_tbp.Klase;
using Aplikacija_za_praćenje_trudnoće_tbp.Funkcionalnosti;

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormPregledTesta : Form
    {
     
        private DataGridViewRow odabraniRedak;

        public FormPregledTesta(DataGridViewRow redak)
        {
            InitializeComponent();
            this.odabraniRedak = redak;
        }

        private void FormPregledTesta_Load(object sender, EventArgs e)
        {
            if (odabraniRedak != null)
            {
                txtTest.Text = odabraniRedak.Cells["naziv_testa"].Value.ToString();
                richTextBoxTest.Text = odabraniRedak.Cells["opis"].Value.ToString();
                txtDatumIVrijemeKreiranja.Text = odabraniRedak.Cells["datum_vrijeme_kreiranja"].Value.ToString();

               
                if (odabraniRedak!=null)
                {
                    object slikaValue = odabraniRedak.Cells["slika"].Value;
                    if (slikaValue != null && slikaValue != DBNull.Value)
                    {
                        byte[] slikaBytes = (byte[])slikaValue;
                        using (MemoryStream ms= new MemoryStream(slikaBytes))
                        {
                            Image slika = Image.FromStream(ms);
                            pictureTest.Image = slika;
                        }
                    }
                }



            }

        }

       

     
        
    }
}

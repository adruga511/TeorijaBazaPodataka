using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Aplikacija_za_praćenje_trudnoće_tbp.Funkcionalnosti;
using Aplikacija_za_praćenje_trudnoće_tbp.Klase;

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormPregledDnevnika : Form
    {
        private DataGridViewRow odabraniRedak;
        public FormPregledDnevnika(DataGridViewRow redak)
        {
            InitializeComponent();
            this.odabraniRedak = redak;
        }

        private void FormPregledDnevnika_Load(object sender, EventArgs e)
        {
            if (odabraniRedak != null)
            {     
                richTextBoxDnevnikPregled.Text = odabraniRedak.Cells["opis"].Value.ToString();
               
            }
           
        }

        private void IzmijeniDnevnik(DateTime datumVrijemeKreiranja, string opis, int id)
        {


            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "UPDATE dnevnik_trudnice SET datum_vrijeme_kreiranja = @datum_vrijeme_kreiranja,opis = @opis WHERE id_dnevnik = @id_dnevnik";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@datum_vrijeme_kreiranja", datumVrijemeKreiranja);
                    command.Parameters.AddWithValue("@opis", opis);
                    command.Parameters.AddWithValue("@id_dnevnik", id);


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dnevnik je uspješno izmijenjen.");
                    }
                    catch (PostgresException ex)
                    {
                        MessageBox.Show("Greška prilikom izmjene dnevnika: " + ex.MessageText);
                    }

                }
                veza.Close();

            }

        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(odabraniRedak.Cells["id_dnevnik"].Value);
            IzmijeniDnevnik(DateTime.Now, richTextBoxDnevnikPregled.Text, id);
            
        }
    }

    
}

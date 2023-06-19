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
    public partial class FormPregledEvidencije : Form
    {
        private DataGridViewRow odabraniRedak;
        
        public FormPregledEvidencije(DataGridViewRow redak)
        {
            InitializeComponent();
            this.odabraniRedak = redak;
            

        }

        private void FormPregledEvidencije_Load(object sender, EventArgs e)
        {
            if (odabraniRedak != null)
            {
                txtBrojOtkucajaSrca.Text = odabraniRedak.Cells["broj_otkucaja_srca"].Value.ToString();
                txtTezina.Text = odabraniRedak.Cells["tezina_trudnice"].Value.ToString();
 
            }
            
        }

        private void IzmijeniOtkucajeTezinu(DateTime vrijemeDatumEvidencije, int otkucaji, int tezina, int id)
        {


            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "UPDATE evidencija SET vrijeme_datum_evidencije = @vrijeme_datum_evidencije, broj_otkucaja_srca = @otkucaji, tezina_trudnice= @tezina WHERE id_evidencija = @id_evidencija";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@vrijeme_datum_evidencije", vrijemeDatumEvidencije);
                    command.Parameters.AddWithValue("@otkucaji", otkucaji);
                    command.Parameters.AddWithValue("@tezina", tezina);
                    command.Parameters.AddWithValue("@id_evidencija", id);



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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(odabraniRedak.Cells["id_evidencija"].Value);
            IzmijeniOtkucajeTezinu(DateTime.Now, int.Parse(txtBrojOtkucajaSrca.Text), int.Parse(txtTezina.Text), id);
        }

       
    }
}

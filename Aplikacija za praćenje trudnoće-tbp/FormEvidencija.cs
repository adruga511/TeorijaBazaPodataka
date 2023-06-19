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
    public partial class FormEvidencija : Form
    {
        DataTable dt;
        NpgsqlDataAdapter adpt;
        public FormEvidencija()
        {
            InitializeComponent();
            OsvjeziDvg();
        }
      

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FormPocetniIzbornik formPocetniIzbornik = new FormPocetniIzbornik();
            formPocetniIzbornik.Show();
            this.Hide();
        }

        private void OsvjeziDvg()
        {
            adpt = new NpgsqlDataAdapter("SELECT * FROM evidencija WHERE id_trudnica=" + Trudnica.id_trudnice + "", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvEvidencija.DataSource = dt;

            dgvEvidencija.Columns[0].Visible = false;
            dgvEvidencija.Columns[2].Visible = false;
        }

        public static void DodajTezinuOtkucaje(DateTime vrijemeDatumEvidencije, int otkucajiSrca, Double tezina)
        {

            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "INSERT INTO evidencija (vrijeme_datum_evidencije, id_trudnica, broj_otkucaja_srca, tezina_trudnice) VALUES (@vrijeme_datum_evidencije, @id_trudnica, @broj_otkucaja_srca, @tezina_trudnice)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@vrijeme_datum_evidencije", vrijemeDatumEvidencije);
                    command.Parameters.AddWithValue("@broj_otkucaja_srca", otkucajiSrca);
                    command.Parameters.AddWithValue("@tezina_trudnice", tezina);
                    command.Parameters.AddWithValue("@id_trudnica", Trudnica.id_trudnice);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (PostgresException ex)
                    {
                        MessageBox.Show(ex.MessageText);
                    }

                }
                veza.Close();

            }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DodajTezinuOtkucaje(dtpEvidencija.Value,int.Parse(txtBrojOtkucajaSrca.Text), double.Parse(txtTezina.Text));
            OsvjeziDvg();
            txtTezina.Clear();
            txtBrojOtkucajaSrca.Clear();
        }

        public static void ObrisiTezinuOtkucaje(int id)
        {
            using (NpgsqlConnection veza = Connection.SpojiSe())
            {

                string sql = "DELETE FROM evidencija WHERE id_evidencija='" + id + "';";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@id_evidencija", id);
                    command.ExecuteNonQuery();

                }
            }
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (dgvEvidencija.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRedak = dgvEvidencija.SelectedRows[0];
                int id = Convert.ToInt32(odabraniRedak.Cells["id_evidencija"].Value);
                ObrisiTezinuOtkucaje(id);
                dgvEvidencija.Rows.Remove(odabraniRedak);

            }
            OsvjeziDvg();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
             if (dgvEvidencija.SelectedRows.Count > 0)
             {
                 DataGridViewRow odabraniRedak = dgvEvidencija.SelectedRows[0];
                 FormPregledEvidencije formPregledEvidencije = new FormPregledEvidencije(odabraniRedak);
                 formPregledEvidencije.ShowDialog();

             }
             OsvjeziDvg();

           

        }

        private void FormEvidencija_Load(object sender, EventArgs e)
        {
           
            OsvjeziDvg();
        }

        
         
    }

   }

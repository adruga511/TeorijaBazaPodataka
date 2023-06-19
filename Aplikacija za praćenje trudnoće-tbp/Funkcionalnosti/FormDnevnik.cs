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
using Aplikacija_za_praćenje_trudnoće_tbp.Klase;
using Aplikacija_za_praćenje_trudnoće_tbp.Funkcionalnosti;


namespace Aplikacija_za_praćenje_trudnoće_tbp.Funkcionalnosti
{
    public partial class FormDnevnik : Form
    {
        DataTable dt;
        NpgsqlDataAdapter adpt;


        public FormDnevnik()
        {
            InitializeComponent();
            OsvjeziDnevnik();
        }


        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            FormPocetniIzbornik formPocetniIzbornik = new FormPocetniIzbornik();
            formPocetniIzbornik.Show();
            this.Hide();
        }

        private void buttonDnevnik_Click(object sender, EventArgs e)
        {
            DodajDnevnikTrudnice(richTextBoxDnevnik.Text, dtpDnevnik.Value);
            OsvjeziDnevnik();
            richTextBoxDnevnik.Clear();
        }



        private void OsvjeziDnevnik()
        {
            adpt = new NpgsqlDataAdapter("SELECT * FROM dnevnik_trudnice WHERE id_trudnica=" + Trudnica.id_trudnice + "", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvDnevnik.DataSource = dt;

            dgvDnevnik.Columns[0].Visible = false;
            dgvDnevnik.Columns[3].Visible = false;
        }

        public static void DodajDnevnikTrudnice(string dnevnik, DateTime datumVrijemeKreiranja)
        {
           
            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "INSERT INTO dnevnik_trudnice (datum_vrijeme_kreiranja, opis, id_trudnica) VALUES (@datum_vrijeme_kreiranja, @opis, @id_trudnica)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@datum_vrijeme_kreiranja", datumVrijemeKreiranja);
                    command.Parameters.AddWithValue("@opis", dnevnik);
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

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            if (dgvDnevnik.SelectedRows.Count>0)
            {
                DataGridViewRow odabraniRedak = dgvDnevnik.SelectedRows[0];
                int id = Convert.ToInt32(odabraniRedak.Cells["id_dnevnik"].Value);
                ObrisiDnevnikTrudnice(id);
                dgvDnevnik.Rows.Remove(odabraniRedak);

            }
            OsvjeziDnevnik();


        }

        public static void ObrisiDnevnikTrudnice(int id)
        {
            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
              
                string sql = "DELETE FROM dnevnik_trudnice WHERE id_dnevnik='" + id + "';";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@id_dnevnik", id);
                    command.ExecuteNonQuery();

                }
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dgvDnevnik.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRedak = dgvDnevnik.SelectedRows[0];
                FormPregledDnevnika formPregledDnevnika = new FormPregledDnevnika(odabraniRedak);
                formPregledDnevnika.ShowDialog();

            }
            OsvjeziDnevnik();
        }
    }
}

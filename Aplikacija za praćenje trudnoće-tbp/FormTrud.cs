using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikacija_za_praćenje_trudnoće_tbp.Klase;
using Npgsql;
using System.Diagnostics;

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormTrud : Form
    {
        int timeMs, timeS, timeMin;
        bool isActive;
        DataTable dt;
        NpgsqlDataAdapter adpt;
        

        public FormTrud()
        {
            InitializeComponent();
            OsvjeziTrud();
        }

        private void OsvjeziTrud()
        {
            adpt = new NpgsqlDataAdapter("SELECT * FROM trudovi WHERE id_trudnica=" + Trudnica.id_trudnice + "", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvTrudovi.DataSource = dt;

            dgvTrudovi.Columns[0].Visible = false;
            dgvTrudovi.Columns[3].Visible = false;
        }

        private void btnPocetak_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnZavrsetak_Click(object sender, EventArgs e)
        {
            isActive = false;

            DateTime trenutnoVrijeme = DateTime.Now;

            int minute = timeMin;
            int sekunde = timeS;
            int milisekunde = timeMs;

            int ukupnoTrajanje=(minute * 60 * 1000) + (sekunde * 1000) + milisekunde;

            DateTime zavrsetakTruda = trenutnoVrijeme.AddMilliseconds(ukupnoTrajanje);

            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "INSERT INTO trudovi (pocetak_truda, zavrsetak_truda, id_trudnica) VALUES (@pocetak_truda, @zavrsetak_truda, @id_trudnica)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@pocetak_truda", trenutnoVrijeme);
                    command.Parameters.AddWithValue("@zavrsetak_truda", zavrsetakTruda);
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
            OsvjeziTrud();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();

        }

        private void ResetTime()
        {
            timeMs = 0;
            timeS = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeMs++;
                if (timeMs>=100)
                {
                    timeS++;
                    timeMs = 0;
                    if (timeS>=60)
                    {
                        timeMin++;
                        timeS = 0;
                    }
                }
            }
            DrawTime();
            
        }

        private void DrawTime()
        {
            lblMilisekunde.Text = String.Format("{0,00}", timeMs);
            lblSekunde.Text = String.Format("{0,00}", timeS);
            lblMinute.Text = String.Format("{0,00}", timeMin);
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            FormPocetniIzbornik formPocetniIzbornik = new FormPocetniIzbornik();
            formPocetniIzbornik.Show();
            this.Hide();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvTrudovi.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRedak = dgvTrudovi.SelectedRows[0];
                int id = Convert.ToInt32(odabraniRedak.Cells["id_trudovi"].Value);
                ObrisiTrud(id);
                dgvTrudovi.Rows.Remove(odabraniRedak);

            }
            OsvjeziTrud();
        }

        private void FormTrud_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;

        }

        public static void ObrisiTrud(int id)
        {
            using (NpgsqlConnection veza = Connection.SpojiSe())
            {

                string sql = "DELETE FROM trudovi WHERE id_trudovi='" + id + "';";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@id_trudovi", id);
                    command.ExecuteNonQuery();

                }
            }
        }


    }
}

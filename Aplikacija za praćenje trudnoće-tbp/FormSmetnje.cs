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
using Aplikacija_za_praćenje_trudnoće_tbp.Properties;
using Npgsql;
using NpgsqlTypes;


namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormSmetnje : Form
    {

        DataTable dt;
        NpgsqlDataAdapter adpt;
       
        public FormSmetnje()
        {
            InitializeComponent();
            OsvjeziDgv();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FormPocetniIzbornik formPocetniIzbornik = new FormPocetniIzbornik();
            formPocetniIzbornik.Show();
            this.Hide();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            string selectedSmetnja = cboSmetnje.SelectedItem.ToString();

            int smetnjaID = GetSmetnjaID(selectedSmetnja);

            if (smetnjaID != -1)
            {

                DodajSmetnju(dtpSmetnja.Value, smetnjaID);

            }
            OsvjeziDgv();
            
        }

        private int GetSmetnjaID(string nazivSmetnje)
        {
            int smetnjaID = -1; 

            try
            {
                using (NpgsqlConnection veza = Connection.SpojiSe())
                {
                    string sql = "SELECT id_smetnja FROM smetnja WHERE naziv_smetnje = @nazivSmetnje";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                    {
                        command.Parameters.AddWithValue("@nazivSmetnje", nazivSmetnje);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            smetnjaID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se greška" + ex.Message);
                }
            return smetnjaID;

        }

        private void DohvatiSmetnje()
        {
            adpt = new NpgsqlDataAdapter("SELECT * FROM smetnja", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSmetnje.Items.Add(dt.Rows[i]["naziv_smetnje"]);
            }

        }

        private void FormSmetnje_Load(object sender, EventArgs e)
        {
            DohvatiSmetnje();
        }
        private void OsvjeziDgv()
        {
            adpt = new NpgsqlDataAdapter("SELECT t.vrijeme_datum_smetnje, t.id_smetnje, s.naziv_smetnje " +
                             "FROM smetnje_tijekom_trudnoce t " +
                             " JOIN smetnja s ON t.id_smetnja = s.id_smetnja WHERE id_trudnica=" + Trudnica.id_trudnice + " ORDER BY vrijeme_datum_smetnje", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvSmetnje.DataSource = dt;
            dgvSmetnje.Columns[1].Visible = false;
            
        }


        private void DodajSmetnju(DateTime vrijemeDatumKreiranja, int smetnjaID)
        {

            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "INSERT INTO smetnje_tijekom_trudnoce (vrijeme_datum_smetnje, id_smetnja, id_trudnica) VALUES (@vrijeme_datum_smetnje, @id_smetnja, @id_trudnica)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@vrijeme_datum_smetnje", vrijemeDatumKreiranja);
                    command.Parameters.AddWithValue("@id_smetnja", smetnjaID);
                    command.Parameters.AddWithValue("@id_trudnica", Trudnica.id_trudnice);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Smetnja je uspješno spremljena.");
                    }
                    catch (PostgresException ex)
                    {
                        MessageBox.Show("Greška prilikom spremanja smetnje: " + ex.MessageText);
                    }

                }
                veza.Close();

            }




        }


        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvSmetnje.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRedak = dgvSmetnje.SelectedRows[0];
                int id = Convert.ToInt32(odabraniRedak.Cells["id_smetnje"].Value);
                ObrisiSmetnju(id);
                dgvSmetnje.Rows.Remove(odabraniRedak);

            }
            OsvjeziDgv();
        }

        public static void ObrisiSmetnju(int id)
        {
            using (NpgsqlConnection veza = Connection.SpojiSe())
            {

                string sql = "DELETE FROM smetnje_tijekom_trudnoce WHERE id_smetnje='" + id + "';";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@id_smetnje", id);
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}

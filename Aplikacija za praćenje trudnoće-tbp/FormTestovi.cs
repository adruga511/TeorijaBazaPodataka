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
using System.IO;

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormTestovi : Form
    {
        DataTable dt;
        NpgsqlDataAdapter adpt;
        public FormTestovi()
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

        private void DohvatiTestove()
        {
            adpt = new NpgsqlDataAdapter("SELECT * FROM test", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboTestovi.Items.Add(dt.Rows[i]["naziv_testa"]);
            }

        }

        private void FormTestovi_Load(object sender, EventArgs e)
        {
            DohvatiTestove();
        }

        private void OsvjeziDgv()
        {
            adpt = new NpgsqlDataAdapter("SELECT o.datum_vrijeme_kreiranja, o.opis,o.id_obavljeni_test,o.slika, t.naziv_testa " +
                             "FROM obavljeni_test o " +
                             " JOIN test t ON o.id_test = t.id_test WHERE id_trudnice=" + Trudnica.id_trudnice + " ORDER BY datum_vrijeme_kreiranja", Connection.SpojiSe());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvTestovi.DataSource = dt;

            dgvTestovi.Columns[2].Visible = false;
        
        }

        private int DohvatiTestId(string nazivTesta)
        {
            int testID = -1;

            try
            {
                using (NpgsqlConnection veza = Connection.SpojiSe())
                {
                    string sql = "SELECT id_test FROM test WHERE naziv_testa = @nazivTesta";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                    {
                        command.Parameters.AddWithValue("@nazivTesta", nazivTesta);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            testID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se greška" + ex.Message);
            }
            return testID;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            if (!string.IsNullOrEmpty(imgLocation))
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                images = br.ReadBytes((int)stream.Length);

            }

            string odabraniTest = cboTestovi.SelectedItem.ToString();
            int testID = DohvatiTestId(odabraniTest);

            if (testID != -1)
            {
              
                    DodajTest(dtpTestovi.Value, testID, richTextBoxTestovi.Text, images);
            }
            OsvjeziDgv();
            richTextBoxTestovi.Clear();

           

            
            
        }

        private void DodajTest(DateTime datumVrijemeKreiranja, int testID, string opis,byte[] slika )
        {
           

            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "INSERT INTO obavljeni_test (datum_vrijeme_kreiranja, id_trudnice, id_test, opis, slika) VALUES (@datum_vrijeme_kreiranja, @id_trudnice, @id_test, @opis, @slika)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@datum_vrijeme_kreiranja", datumVrijemeKreiranja);
                    command.Parameters.AddWithValue("@id_trudnice", Trudnica.id_trudnice);
                    command.Parameters.AddWithValue("@id_test", testID);
                    command.Parameters.AddWithValue("@opis", opis);
                    command.Parameters.AddWithValue("@slika", (object)slika ?? DBNull.Value);

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
            if (dgvTestovi.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRedak = dgvTestovi.SelectedRows[0];
                int id = Convert.ToInt32(odabraniRedak.Cells["id_obavljeni_test"].Value);
                ObrisiTest(id);
                dgvTestovi.Rows.Remove(odabraniRedak);

            }
            OsvjeziDgv();
        }

         public static void ObrisiTest(int id)
        {
            using (NpgsqlConnection veza = Connection.SpojiSe())
            {

                string sql = "DELETE FROM obavljeni_test WHERE id_obavljeni_test='" + id + "';";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    command.Parameters.AddWithValue("@id_obavljeni_test", id);
                    command.ExecuteNonQuery();

                }
            }
        }

        string imgLocation = "";
        NpgsqlCommand cmd;
        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureTest.ImageLocation = imgLocation;
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dgvTestovi.SelectedRows.Count > 0)
            {
                DataGridViewRow odabraniRedak = dgvTestovi.SelectedRows[0];
                FormPregledTesta formPregledTesta = new FormPregledTesta(odabraniRedak);
                formPregledTesta.ShowDialog();

            }
            OsvjeziDgv();
        }
    }
}

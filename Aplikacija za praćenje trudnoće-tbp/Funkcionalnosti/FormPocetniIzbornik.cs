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

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormPocetniIzbornik : Form
    {
        public FormPocetniIzbornik()
        {
            InitializeComponent();
        }

        private void buttonDnevnik_Click(object sender, EventArgs e)
        {
            FormDnevnik formDnevnik = new FormDnevnik();
            formDnevnik.Show();
            this.Hide();
        }

        private void buttonTrudovi_Click(object sender, EventArgs e)
        {
            FormTrud formTrud = new FormTrud();
            formTrud.Show();
            this.Hide();
        }

        private string DohvatiDaneDoPoroda()
        {
            string dani = "ostatak_dana";

            using (NpgsqlConnection veza = Connection.SpojiSe())
            {
                string sql = "SELECT ostatak_dana FROM trudnica WHERE id_trudnice = "+Trudnica.id_trudnice+"";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, veza))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string value = reader.GetString(0);
                            return value;
                        }
                    }

                }
                

            }
            return dani;
        }

        private void FormPocetniIzbornik_Load(object sender, EventArgs e)
        {
            string dani = DohvatiDaneDoPoroda();
            txtOstatakDana.Text = dani;
        }

        private void buttonSmetnje_Click(object sender, EventArgs e)
        {
            FormSmetnje formSmetnje = new FormSmetnje();
            formSmetnje.Show();
            this.Hide();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FormTestovi formTestovi = new FormTestovi();
            formTestovi.Show();
            this.Hide();
        }

        private void btnEvidencija_Click(object sender, EventArgs e)
        {
            FormEvidencija formEvidencija = new FormEvidencija();
            formEvidencija.Show();
            this.Hide();
        }
    }
}

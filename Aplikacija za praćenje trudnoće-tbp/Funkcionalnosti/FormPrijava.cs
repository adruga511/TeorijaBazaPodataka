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

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public partial class FormPrijava : Form
    {

        public FormPrijava()
        {
            InitializeComponent();
        }
        NpgsqlConnection konekcija = new NpgsqlConnection(@"Server=localhost; Port=5432;User Id=postgres;Password=bombek123;Database=teorija_baze_podataka;");

        private void FormPrijava_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {

            if (Connection.PrijaviSe(textBoxEmail.Text, textBoxLozinka.Text))
            {
                FormPocetniIzbornik novaForma = new FormPocetniIzbornik();
                novaForma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Krivo upisan email ili lozinka");
            }


        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxLozinka.Clear();

            textBoxEmail.Focus();
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            FormRegistracija formRegistracija = new FormRegistracija();
            formRegistracija.Show();
            this.Hide();
        }
    }
}

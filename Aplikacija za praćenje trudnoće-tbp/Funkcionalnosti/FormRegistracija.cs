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
    public partial class FormRegistracija : Form
    {
        public FormRegistracija()
        {
            InitializeComponent();
        }
        

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxEmail.Clear();
            textBoxLozinka.Clear();
   
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            FormPrijava formPrijava = new FormPrijava();
            formPrijava.Show();
            this.Hide();
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {

            String ime, prezime, email, lozinka;
            DateTime predvideni_termin_poroda;
            ime = textBoxIme.Text;
            prezime = textBoxPrezime.Text;
            email = textBoxEmail.Text;
            lozinka = textBoxLozinka.Text;
            predvideni_termin_poroda = dateTimePickerPorod.Value.Date;

            Connection.RegistrirajSe(ime, prezime, email, lozinka, predvideni_termin_poroda);
            MessageBox.Show("Registracija uspješno obavljena!");
            this.Close();

            FormPrijava formPrijava = new FormPrijava();
            formPrijava.Show();
            this.Hide();

        }
    }
}

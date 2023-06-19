using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Aplikacija_za_praćenje_trudnoće_tbp.Klase
{
    public static class Connection
    {

        public static NpgsqlConnection connection;
        public static NpgsqlConnection SpojiSe()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=projekt;UserId=postgres;" +
                "Password=bombek123;Database=teorija_baze_podataka;");
            connection.Open();
            return connection;

        }

        public static void RegistrirajSe(string ime, string prezime, string email, string lozinka, DateTime predvideni_termin_poroda)
        {
            NpgsqlConnection veza = SpojiSe();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText= "INSERT INTO trudnica (ime, prezime, email, lozinka, predvideni_termin_poroda) VALUES " +
                    "('" + ime + "', '" + prezime + "', '" + email + "', '" + lozinka + "', '" + predvideni_termin_poroda + "')";
            command.ExecuteNonQuery();
            veza.Close();
        }
        public  static void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public static bool PrijaviSe(string email, string lozinka)
        {
            
            NpgsqlConnection veza = SpojiSe();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM public.trudnica WHERE email = '" + email + "';";
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {


                Trudnica.id_trudnice = int.Parse(dr["id_trudnice"].ToString());
                Trudnica.ime = dr["ime"].ToString();
                Trudnica.prezime = dr["prezime"].ToString();
                Trudnica.email = dr["email"].ToString();
                Trudnica.lozinka = dr["lozinka"].ToString();
                Trudnica.predvideni_termin_poroda = DateTime.Parse(dr["predvideni_termin_poroda"].ToString());

                veza.Close();
                return true;
            }
            veza.Close();
            return false;
        }


    }
}

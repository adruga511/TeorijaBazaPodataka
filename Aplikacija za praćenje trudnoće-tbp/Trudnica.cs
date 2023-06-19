using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_praćenje_trudnoće_tbp
{
    public static class Trudnica
    {
        public static int id_trudnice { get; set; }
        public static string ime { get; set; }
        public static string prezime { get; set; }
        public static string email { get; set; }
        public static string lozinka { get; set; }
        public static DateTime predvideni_termin_poroda { get; set; }
    }
}

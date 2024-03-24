using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GestionPensionEtBox.DAO
{
    public class Connexion
    {
        private static MySqlConnection conn = new MySqlConnection();

        static string server = "localhost";
        static string database = "la_mise_au_vert";
        static string user = "root";
        static string password = "";
        public static MySqlConnection Connection() 
        {
            conn = new MySqlConnection($"server={server};database={database};uid={user};pwd={password}");
            conn.Open();
            return conn;
        }
        public void connOpen()
        {
            Connection();
            conn.Open();
        }
        public void connClose()
        {
            Connection();
            conn.Close();
        }
    }
}

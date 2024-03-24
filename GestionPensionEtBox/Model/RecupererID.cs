using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPensionEtBox.Model
{
    class RecupererID
    {
        static public string afficherIDpension(string nomPension)
        {
            string stmt = "SELECT id_pension FROM pension WHERE nom_pension =@nomPension";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            cmd.Parameters.AddWithValue("@nomPension", nomPension);
            string id = cmd.ExecuteScalar().ToString();
            return id;
        }
        static public string afficherIDtypeGard(string libelle)
        {
            string stmt = "SELECT id_TypeGardiennage FROM typeGardiennage WHERE libelle =@libelle";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            cmd.Parameters.AddWithValue("@libelle", libelle);
            string id = cmd.ExecuteScalar().ToString() ;
            return id;
        }

    }
}

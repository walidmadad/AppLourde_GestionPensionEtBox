using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPensionEtBox.Model;

namespace GestionPensionEtBox.Controller
{
    class TypeGardiennage
    {
        public static ArrayList AfficherTypeGard()
        {
            ArrayList list = new ArrayList();
            string stmt = "SELECT libelle FROM typegardiennage";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string nom = mySqlDataReader.GetString("libelle");
                list.Add(nom);
            }

            return list;

        }
        public static string AfficherPrix(string nom, string libelle)
        {
            string idPension = RecupererID.afficherIDpension(nom);
            string idTypeGard = RecupererID.afficherIDtypeGard(libelle);
            string stmt = "SELECT tarif FROM tarification WHERE Pension_id =@idPension AND Type_Gardiennage_id =@idTypeGard";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            cmd.Parameters.AddWithValue("@idPension", idPension);
            cmd.Parameters.AddWithValue("@idTypeGard", idTypeGard);
            if (cmd.ExecuteScalar() != null)
            {
                return cmd.ExecuteScalar().ToString();
            }
            else
            {
                return "Entrez une Valuer";
            }
        }

        public static string AfficherSuperficie(string nom, string libelle)
        {
            string idPension = RecupererID.afficherIDpension(nom);
            string idTypeGard = RecupererID.afficherIDtypeGard(libelle);
            string stmt = "SELECT superficie FROM box WHERE id_pension =@idPension AND id_TypeGardiennage =@idTypeGard";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            cmd.Parameters.AddWithValue("@idPension", idPension);
            cmd.Parameters.AddWithValue("@idTypeGard", idTypeGard);
            if(cmd.ExecuteScalar() != null)
            {
                return cmd.ExecuteScalar().ToString();
            }
            else
            {
                return "Entrez une Valuer";
            }
            
        }

        public static void ModifierTarif(string nom, string libelle, string tarif) {
            string idPension = RecupererID.afficherIDpension(nom);
            string idTypeGard = RecupererID.afficherIDtypeGard(libelle);
            string stmt = "SELECT tarif FROM tarification WHERE Pension_id =@idPension AND Type_Gardiennage_id =@idTypeGard";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            cmd.Parameters.AddWithValue("@idPension", idPension);
            cmd.Parameters.AddWithValue("@idTypeGard", idTypeGard);

            if(cmd.ExecuteScalar() != null)
            {
                string stmt2 = "UPDATE tarification SET tarif =@tarif WHERE Pension_id =@idPension AND Type_Gardiennage_id =@idTypeGard";
                var cmd2 = new MySqlCommand(stmt2, DAO.Connexion.Connection());
                cmd2.Parameters.AddWithValue("@tarif", tarif);
                cmd2.Parameters.AddWithValue("@idPension", idPension);
                cmd2.Parameters.AddWithValue("@idTypeGard", idTypeGard);
                cmd2.ExecuteReader();
            }
            else
            {
                string stmt2 = "INSERT INTO tarification(tarif, pension_id, TypeGardiennage_id) VALUES (@tarif, @idPension ,@idTypeGard)";
                var cmd2 = new MySqlCommand(stmt2, DAO.Connexion.Connection());
                cmd2.Parameters.AddWithValue("@tarif", tarif);
                cmd2.Parameters.AddWithValue("@idPension", idPension);
                cmd2.Parameters.AddWithValue("@idTypeGard", idTypeGard);
                cmd2.ExecuteNonQuery();
            }

        }
        public static void ModifierSuperficie(string nom, string libelle, string superficie)
        {
            string idPension = RecupererID.afficherIDpension(nom);
            string idTypeGard = RecupererID.afficherIDtypeGard(libelle);
            string stmt = "SELECT superficie FROM box WHERE id_pension =@idPension AND id_TypeGardiennage =@idTypeGard";
            var cmd = new MySqlCommand(stmt, DAO.Connexion.Connection());
            cmd.Parameters.AddWithValue("@idPension", idPension);
            cmd.Parameters.AddWithValue("@idTypeGard", idTypeGard);

            if (cmd.ExecuteScalar() != null)
            {
                string stmt2 = "UPDATE box SET superficie =@superficie WHERE id_pension =@idPension AND id_TypeGardiennage =@idTypeGard";
                var cmd2 = new MySqlCommand(stmt2, DAO.Connexion.Connection());
                cmd2.Parameters.AddWithValue("@superficie", superficie);
                cmd2.Parameters.AddWithValue("@idPension", idPension);
                cmd2.Parameters.AddWithValue("@idTypeGard", idTypeGard);
                cmd2.ExecuteReader();
            }
            else
            {
                string stmt2 = "INSERT INTO box(superficie, id_pension, id_TypeGardiennage) VALUES (@superficie, @idPension, @idTypeGard)";
                var cmd2 = new MySqlCommand(stmt2, DAO.Connexion.Connection());
                cmd2.Parameters.AddWithValue("@superficie", superficie);
                cmd2.Parameters.AddWithValue("@idPension", idPension);
                cmd2.Parameters.AddWithValue("@idTypeGard", idTypeGard);
                cmd2.ExecuteNonQuery();
            }

        }
    }
}

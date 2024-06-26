using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GeoQuiz
{
    public class Datenbank
    {
        private MySqlConnection con;

        public Datenbank()
        {
            string conStr = "SERVER=localhost;DATABASE=GeoQuiz;" +
                "UID=root;PASSWORD=''";
            con = new MySqlConnection(conStr);
        }

        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void schliessen()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public List<Laendern> getLaendern()
        {
            List<Laendern> liLA = new List<Laendern>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Land;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liLA.Add(
                    new Laendern(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? "" : dr.GetString(3)
                        )
                    );
            }
            dr.Close();
            schliessen();
            return liLA;
        }

        public List<Spieler> getSpieler()
        {
            List<Spieler> liSP = new List<Spieler>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Spieler;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liSP.Add(
                    new Spieler(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? -1 : dr.GetInt32(2)
                        )
                    );
            }
            dr.Close();
            schliessen();
            return liSP;
        }

        public List<Laendern> getRandom(int limit)
        {
            List<Laendern> liLA = new List<Laendern>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Land ORDER BY RAND() LIMIT {limit};";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liLA.Add(
                    new Laendern(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? "" : dr.GetString(3)
                    )
                );
            }
            dr.Close();
            schliessen();
            return liLA;
        }
    }


}







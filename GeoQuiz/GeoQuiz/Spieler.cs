using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Spieler
    {
        private int spielerid;
        private string spielername;
        private int spielerscore;

        public int Spielerid { get => spielerid; set => spielerid = value; }
        public string Spielername { get => spielername; set => spielername = value; }
        public int Spielerscore { get => spielerscore; set => spielerscore = value; }

        public Spieler(int SID, string SN, int SHS)
        {
            Spielerid = SID;
            Spielername = SN;
            Spielerscore = SHS;
            Spielerscore = SHS;
        }
    }
}

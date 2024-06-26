using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Laendern
    {
        private int landid;
        private string landname;
        private string landhauptstadt;
        private string kontinent;

        public int Landid { get => landid; set => landid = value; }
        public string Landname { get => landname; set => landname = value; }
        public string Landhauptstadt { get => landhauptstadt; set => landhauptstadt = value; }
        public string Kontinent { get => kontinent; set => kontinent = value; }

        public Laendern(int LID, string LN, string LHS, string KN)
        {
            Landid = LID;
            Landname = LN;
            Landhauptstadt = LHS;
            Kontinent = KN;

        }
    }
}

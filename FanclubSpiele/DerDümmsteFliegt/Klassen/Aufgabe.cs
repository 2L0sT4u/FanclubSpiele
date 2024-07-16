using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.DerDümmsteFliegt.Klassen
{
    public class Aufgabe
    {
        private int id { get; set; }
        private string frage { get; set; }
        private string antwort { get; set; }


        public Aufgabe(int id, string frage, string antwort)
        {
            this.id = id;
            this.frage = frage;
            this.antwort = antwort;
        }
    }
}

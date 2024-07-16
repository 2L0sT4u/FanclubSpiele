using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.DerDümmsteFliegt.Klassen
{
    internal class Spieler
    {
        public int id { get; set; }
        public string name { get; set; }
        public string leben { get; set; }

        public Spieler(int id, string name, string leben)
        {
            this.id = id;
            this.name = name;
            this.leben = leben;
        }
    }
}

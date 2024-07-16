﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.DerDümmsteFliegt.Klassen
{
    public class Aufgabe
    {
        public int id { get; set; }
        public string frage { get; set; }
        public string antwort { get; set; }


        public Aufgabe(int id, string frage, string antwort)
        {
            this.id = id;
            this.frage = frage;
            this.antwort = antwort;
        }
    }
}

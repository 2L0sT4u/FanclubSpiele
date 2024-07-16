using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.Jeopardy
{
    internal class Frage
    {
        private string frage;
        private string antwort;
        private int reward;

        public Frage(string Frage,string Antwort,int reward) {
            this.frage = Frage;
            this.antwort = Antwort;
            this.reward = reward;
        }

        public string getFrage() { return this.frage; }
        public string getAntwort() { return this.antwort; }
        public int getReward() { return this.reward; }
        public void setFrage(string x) { this.frage = x; }
        public void setAntwort(string x) { this.antwort = x; }
        public void setReward(int x) { this.reward = x; }
        
    }
}   

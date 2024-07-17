using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FanclubSpiele.Jeopardy
{
    [Serializable]
    public  class Fragen
    {
        

        private string frage;
        private string antwort;
        private int reward;
        private string group;

        public Fragen() { }

        public Fragen(string Frage,string Antwort,string Group,int reward) {
            this.frage = Frage;
            this.antwort = Antwort;
            this.reward = reward;
            this.group = Group;
        }

        public string getFrage() { return this.frage; }
        public string getAntwort() { return this.antwort; }
        public string getGroup() {  return this.group; }
        public int getReward() { return this.reward; }

        public void setFrage(string x) { this.frage = x; }
        public void setAntwort(string x) { this.antwort = x; }
        public void setReward(int x) { this.reward = x; }
        public void setGroup(string x) {this.group = x; }
        
    }
}   

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.JeoPardy
{
    internal class Player
    {
        string name = string.Empty;
        int Teamid; int live;
        System.Drawing.Color TeamColor;
        public Player(string name_ref) {
            this.name = name_ref;
            this.live = 3;
        }

        public System.Drawing.Color getColor() { return this.TeamColor; }
        public void setColor(System.Drawing.Color color_ref) {  this.TeamColor = color_ref; }
        public string getName() { return this.name; }
        public int getTeamid() { return this.Teamid; }
        public void setTeamid(int id) { this.Teamid = id; }



        

    }
}

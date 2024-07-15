using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.JeoPardy
{
    internal class Player
    {
        string name = string.Empty;
        int color = 0;
        int live = 0;
        public Player(string name_ref,int color_ref) {
            this.name = string.Empty;
            this.color = color_ref;
            this.live = 3;
        }

        public void markPlayer(int color_ref)
        {
            this.color=color_ref;
        }

        public int getColor() { return this.color; }
        public void setColor(int color_ref) {  this.color = color_ref; }
        public string getName() { return this.name; }



        

    }
}

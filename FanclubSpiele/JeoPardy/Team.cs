using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.JeoPardy
{
    internal class Team
    {
        private Player p1; private Player p2;
        private int points = 0;
        public Team(Player p1_ref ,Player p2_ref)
        {
            this.p1= p1_ref;
            this.p2 = p2_ref;
            this.points = 0;
        }   


    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanclubSpiele.JeoPardy
{
    internal class Team
    {
        public static  List<Player> PlayerList = new List<Player>();
        public static Dictionary<System.Drawing.Color,int> TeamFarben = new Dictionary<System.Drawing.Color, int>();

        private Player p1; private Player p2;
        private int points = 0;
        
        public Team(Player p1_ref ,Player p2_ref)
        {
            this.p1= p1_ref;
            this.p2 = p2_ref;
            this.points = 0;
        }
        public static int Player_index_by_name(string name)
        {
            for(int i = 0; i < PlayerList.Count; i++)
            {
                if (PlayerList[i].getName() == name)
                {
                    return i;
                }
            }
            return 0;
        }
        public static System.Drawing.Color setColor(int color) { 
            switch (color)
            {
                case 0:return System.Drawing.Color.Black;
                case 1: return System.Drawing.Color.Gray;
                case 2: return System.Drawing.Color.Blue;
                case 3: return System.Drawing.Color.Green;
                case 4: return System.Drawing.Color.Red;
                case 5: return System.Drawing.Color.Yellow;
            }
            return System.Drawing.Color.Black;
                
        }


    }
}

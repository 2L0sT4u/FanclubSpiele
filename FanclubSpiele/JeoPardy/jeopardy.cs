using FanclubSpiele.JeoPardy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanclubSpiele.Jeopardy
{
    public partial class jeopardy : Form
    {
        List<System.Windows.Forms.Label> labels = new List<System.Windows.Forms.Label>();

        public jeopardy()
        {
            InitializeComponent();
            CreateLabel(Team.PlayerList);

        }
        
        private void CreateLabel(List<Player> players)
        {
            int startY = 50; // Startposition für die Labels
            int spacing = 35; // Abstand zwischen den Labels

            for (int i = 0; i < players.Count; i++) {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                
                
                label.Text = players[i].getName();
                label.Location = new Point(50, startY + i * spacing); // Dynamische Positionierung
                label.AutoSize = true;
                label.Font = new Font("Arial", 20f);

                label.MouseClick += Label_Mouseclick;
                
                labels.Add(label);
                this.Controls.Add(label);

            }
        }
        private int Teamsize_num = 2; private int counter = 0;

        private void Label_Mouseclick(object sender ,MouseEventArgs e)
        {
            
            System.Windows.Forms.Label clickedLabel =sender as System.Windows.Forms.Label;
            int index = Team.Player_index_by_name(clickedLabel.Text);
            if (clickedLabel!= null && clickedLabel.ForeColor != Color.Black)
            {
                if (counter % Teamsize_num == 0)
                {
                    Team.Color_int_max += 1;
                }
                Team.PlayerList[index].setColor(Team.Color_int_max);
                clickedLabel.ForeColor= Team.setColor(Team.Color_int_max) ;
                
            }
            else if (clickedLabel.ForeColor != Color.Black)
            {
                clickedLabel.ForeColor = Color.Black;


            }
            
            counter++;//Farbwechsel bei jedem 2 wird der Farben Int bei dem Player verändert

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

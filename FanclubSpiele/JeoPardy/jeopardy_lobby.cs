using FanclubSpiele.JeoPardy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanclubSpiele.Jeopardy
{
    public partial class jeopardy_lobby : Form
    {
        List<System.Windows.Forms.Label> labels = new List<System.Windows.Forms.Label>();

        public jeopardy_lobby()
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
                label.ForeColor = Color.Gray;

                label.MouseClick += Team_click;
                
                labels.Add(label);
                this.Controls.Add(label);

            }
        }

        private void Team_click(object sender ,MouseEventArgs e)
        {
            
            System.Windows.Forms.Label clickedLabel =sender as System.Windows.Forms.Label;
            int index = Team.Player_index_by_name(clickedLabel.Text);
            if (clickedLabel!= null && clickedLabel.ForeColor == Color.Gray)
            {
                foreach ( KeyValuePair<System.Drawing.Color, int> pair in Team.TeamFarben){

                    if (pair.Value < 2)
                    {
                        Team.PlayerList[index].setColor(pair.Key);
                        Team.PlayerList[index].setTeamid(Team.TeamID[pair.Key]);
                        Team.TeamFarben[pair.Key]=pair.Value+1;
                        clickedLabel.ForeColor = pair.Key;
                        break;
                    }
                }
         
            }
            else if (clickedLabel.ForeColor != Color.Gray)
            {
                foreach (KeyValuePair<System.Drawing.Color, int> pair in Team.TeamFarben)
                {

                    if (clickedLabel.ForeColor == pair.Key)
                    {
                        Team.PlayerList[index].setColor(Color.Gray);
                        Team.PlayerList[index].setTeamid(-1);
                        Team.TeamFarben[pair.Key] = pair.Value - 1;
                        break;
                    }
                }
                clickedLabel.ForeColor = Color.Gray;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void Zufall_btn_Click(object sender, EventArgs e)
        {

        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            jeopardy jeopardy = new jeopardy();
            jeopardy.Show();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Team.resetDictionaryValue();

            foreach (Player p in Team.PlayerList)
            {
                p.setTeamid(-1);
                p.setColor(Color.Gray);

            }
 
            foreach (System.Windows.Forms.Label l in labels)
            {
                l.ForeColor = Color.Gray;
            }
        }
    }
}

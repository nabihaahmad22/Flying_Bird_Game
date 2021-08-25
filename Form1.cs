using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flying_Bird_Game_Windows_Form
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 6;
        int score = 0;
        
        



        public Form1()
        {
            InitializeComponent();
            game_menu.Hide();
           
        }

        private void gametimeevents(object sender, EventArgs e)
        {
            flyingbird.Top += gravity;
            bottomblock.Left -= pipespeed;
            topblock.Left -= pipespeed;
            scoreboard.Text = "Score: " + score;
            


            if (topblock.Left < -150)
            {
                topblock.Left = 600;
                score++;
            }

            if (bottomblock.Left < -160)
            {
                bottomblock.Left = 750;
                score++;
            }
            if (flyingbird.Bounds.IntersectsWith(topblock.Bounds) ||
                flyingbird.Bounds.IntersectsWith(bottomblock.Bounds) ||
                flyingbird.Bounds.IntersectsWith(ground.Bounds)
                )
            {

                endgame();

            }
            if( score >10)
            {
                pipespeed = 10;
            }
            if(flyingbird.Top< -25)
            {
                endgame();

               
            }

             
        }
        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -6;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 6 ;
            }
        }
       private void endgame()
        {
            gametime.Stop();
           
            game_menu.Show();

        }

        private void quitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void restartlabel_Click(object sender, EventArgs e)
        {
            game_menu.Hide();
            gametime.Start();
            flyingbird.Location = new Point(56, 207);
            topblock.Location = new Point(385, -16);
            bottomblock.Location = new Point(277, 313);
            score = 0;

        }
    }
}

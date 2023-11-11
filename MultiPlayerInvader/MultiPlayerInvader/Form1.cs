using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPlayerInvader
{
    public partial class Form1 : Form
    {

        int scoreright = 10, scoreleft = 10;

        int playerspeed = 8;

        int bulletspeedleft, bulletspeedright;

        bool goupright, goupleft;

        bool godownright, godownleft;

        bool gorightright, gorightleft;

        bool goleftleft, goleftright;

        bool shootingleft, shootingright;
        public Form1()
        {
            InitializeComponent();
        }

        private void gametimerevent(object sender, EventArgs e)
        {
            labelright.Text = "Heart : " + scoreright;
            labelleft.Text = "Heart : " + scoreleft;

            if(scoreleft == 0)
            {
                resultlabel.Text = "Player on the right wins!!!!";
                endgame();
            }

            if(scoreright == 0)
            {
                resultlabel.Text = "Player on the left wins!!!!";
                endgame();
            }

            if(goleftleft == true && playerleft.Left>0)
            {
                playerleft.Left -= playerspeed;
            }

            if (gorightleft == true && playerleft.Left < 300)
            {
                playerleft.Left += playerspeed;
            }

            if (goupleft == true && playerleft.Top > 0)
            {
                playerleft.Top -= playerspeed;
            }

            if (godownleft == true && playerleft.Top < 300)
            {
                playerleft.Top += playerspeed;
            }

            if (goleftright == true && playerright.Left > 400)
            {
                playerright.Left -= playerspeed;
            }

            if (gorightright == true && playerright.Left < 900)
            {
                playerright.Left += playerspeed;
            }

            if (goupright == true && playerright.Top > 0)
            {
                playerright.Top -= playerspeed;
            }

            if (godownright == true && playerright.Top < 600)
            {
                playerright.Top += playerspeed;
            }


            if (shootingleft == true)
            {
                bulletspeedleft = 40;
                bulletleft.Left += bulletspeedleft;

            }
            else
            {
                bulletspeedleft = 0;

                bulletleft.Left = -50;
            }

            if(bulletleft.Left > 700)
            {
                shootingleft = false;
            }

            if(bulletright.Left < -50)
            {
                shootingright = false;
            }

            if(shootingright == true)
            {
                bulletspeedright = 40;
                bulletright.Left -= bulletspeedright;
            }
            else
            {
                bulletspeedright = 0;

                bulletright.Left = -50;
            }

            if (bulletleft.Bounds.IntersectsWith(playerright.Bounds))
            {
                shootingleft = false;

                scoreright--;
            }
            if (bulletright.Bounds.IntersectsWith(playerleft.Bounds))
            {
                shootingright = false;

                scoreleft--;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleftright = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                gorightright = true;
            }

            if(e.KeyCode == Keys.Up)
            {
                goupright = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                godownright = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goleftleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                gorightleft = true;
            }

            if (e.KeyCode == Keys.W)
            {
                goupleft = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godownleft = true;
            }

            if(e.KeyCode == Keys.Space && shootingleft == false)
            {
                shootingleft = true;

                bulletleft.Top = playerleft.Top +20;

                bulletleft.Left = playerleft.Left + (playerleft.Width / 2);

            }

            if(e.KeyCode == Keys.P && shootingright == false)
            {
                shootingright = true;

                bulletright.Top = playerright.Top + 20;

                bulletright.Left = playerright.Left + playerright.Width/2;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleftright = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                gorightright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goupright = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godownright = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goleftleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                gorightleft = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goupleft = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godownleft = false;
            }

        }

        private void endgame()
        {

            gametimer.Stop();

        }



    }
}

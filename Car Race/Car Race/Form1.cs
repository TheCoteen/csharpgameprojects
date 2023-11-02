using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Car_Game : Form
    {

        

        int turnspeed = 8;

        int score = 0;

        int enemyspeed = 10;

        int coinspeed = 7;

        int stringspeed = 8;

        bool goright, goleft;

        public Car_Game()
        {
            InitializeComponent();
        }


        private void gametimerevent(object sender, EventArgs e)
        {
            scorelabel.Text = "Score : " + score;

            if(goright == true)
            {
                player.Left += turnspeed;
            }
            if(goleft == true)
            {
                player.Left -= turnspeed;
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string) x.Tag == "string")
                    {
                        x.Top += stringspeed;

                        if (x.Top > 420)
                        {
                            x.Top = -195;
                        }
                    }

                    if((string) x.Tag == "enemy")
                    {
                        x.Top += enemyspeed;
                        
                        if(x.Top > 760)
                        {
                            x.Top = 0;
                        }

                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            endgame();
                        }
                     
                    }
                    if((string)x.Tag == "coin")
                    {
                        x.Top += coinspeed;

                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            score++;
                        }
                        

                        if(x.Top > 797 || x.Visible == false)
                        {
                            x.Top = 0;
                            x.Visible = true;
                        }
                    }
                }
            }


        }


        private void keyisdown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
        }

        private void endgame()
        {
            gametimer.Stop();

            scorelabel.Text += "\nGame over. You lost!!!!";
        }

        //private void restart()

        
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_105_Final
{
    public partial class Game : Form
    {

        ///defining variables
        int jumpSpeed = 10, maxHeight = 20, score = 0, timer = 0, obstacleSpeed = 15, obstaclePassed, highScore = 0;
        bool jumping = false, highScoreBool = false;
        Random r = new Random();
        UserData userData;


        public Game(UserData data)
        {
            InitializeComponent();
            userData = data;
            reset();
        }

        private void Game_Load(object sender, EventArgs e)
        {


            nameTxt.Text = userData.name;
            if (userData.avatarFile != "")
            {
                avatarBox.Image = Bitmap.FromFile(userData.avatarFile);
            }
        }

        private void restartButton_Click(object sender, EventArgs e)//restart button
        {
            reset();

        }

        private void exitButton_Click(object sender, EventArgs e)//exit button
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit the game?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void survivalTimer_Tick(object sender, EventArgs e)//Timer for telling how many seconds passed
        {
            timer++;
            timerText.Text = "You Survived For:" + timer.ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)//main game timer 
        {
            score++;
            skor.Text = score.ToString();
            if (score > 500)
            {
                obstacleSpeed = 20;
                jumpSpeed = 15;
            }

            if (jumping == true && maxHeight > 0)
            {
                player.Top -= jumpSpeed;
                maxHeight--;
            }

            if (jumping == false || maxHeight <= 0)
            {

                if (player.Top < 350)
                {
                    player.Top += jumpSpeed;

                }
                else
                {
                    player.Top = 350;
                    maxHeight = 20;
                }
            }





            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "engel")
                {
                    x.Left -= obstacleSpeed;//moving obstacles to left


                    if (x.Left < -70)//to 
                    {
                        x.Left = r.Next(10, 100) + this.ClientSize.Width;
                        x.Top = r.Next(355, 400);
                        obstaclePassed++;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        endGame();
                    }


                }
            }


        }

        private void Game_KeyDown(object sender, KeyEventArgs e)//key press
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                jumpSpeed = 10;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)//key release
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
            }
        }

        private void reset()//resetting / starting game
        {
            invisible();//hiding UI     

            engel1.Left = 650;
            engel1.Top = r.Next(355, 400);
            engel2.Left = r.Next(900, 1100);
            engel2.Top = r.Next(355, 400);

            player.Left = 100;
            player.Top = 350;

            jumping = false;
            jumpSpeed = 10;
            obstaclePassed = 0;
            score = 0;
            maxHeight = 20;
            timer = 0;
            obstacleSpeed = 10;
            highScoreBool = false;
            gameTimer.Start();
            survivalTimer.Start();
        }

        private void endGame()//game end
        {
            visible();//showing UI

            gameOverText.Text = "You have passed " + obstaclePassed + " obstacles, in " + timer + " seconds!";
            scoreCompare();//compare scores
            if (highScoreBool)
            {
                highScoreText.Text = "New High Score: " + score;//if high score

            }
            else
            {
                highScoreText.Text = "Your Score Is: " + score;//if its not high score
            }
            gameTimer.Stop();
            survivalTimer.Stop();
        }

        private void scoreCompare()
        {
            if (score > highScore)
            {
                highScore = score;
                highScoreBool = true;
            }
        }

        private void visible()
        {
            highScoreText.Visible = true;
            gameOverText.Visible = true;
            exitButton.Visible = true;
            exitButton.Enabled = true;
            restartButton.Enabled = true;
            restartButton.Visible = true;
        }

        private void invisible()
        {
            highScoreText.Visible = false;
            gameOverText.Visible = false;
            exitButton.Visible = false;
            exitButton.Enabled = false;
            restartButton.Enabled = false;
            restartButton.Visible = false;
        }
    }

}

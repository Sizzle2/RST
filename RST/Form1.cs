using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RST
{
    public partial class Form1 : Form
    {
        private bool goUp = false;
        private bool gravity = true;
        private bool cancel = false;
        private bool stop = false;

        private bool shield = false;
        private bool nuke = false;

        private int lives = 3;

        private int pspeed = 8;
        private int gspeed = 6;
        private int espeed = 10;
        private int time = 0;

        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private List<PictureBox> powerupShield = new List<PictureBox>();
        private List<PictureBox> powerupNuke = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.btn1 = true;
            Global.btn2 = true;

            pbshield.Visible = false;
            pbshield.Enabled = false;

            pblives1.Visible = false;
            pblives2.Visible = false;
            pblives3.Visible = false;
            _lblscore.Visible = false;
            lblscore.Visible = false;

            pbhover.Visible = false;

            pbexplosion.Visible = false;
            pbexplosion.Enabled = false;

            Global.score = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case
                    Keys.Space:
                    timer1.Start();
                    goUp = true;
                    pbhover.Visible = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbplayer.Location.Y <= 30)
            {
                goUp = false;
                cancel = true;
            }
            else if (pbplayer.Location.Y > 30)
            {
                goUp = true;
            }

            if (goUp == true & stop == false)
            {
                pbplayer.Top -= pspeed;
                pbhover.Top -= pspeed;
                pbshield.Top -= pspeed;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case
                    Keys.Space:
                    timer1.Stop();
                    goUp = false;
                    cancel = false;
                    pbhover.Visible = false;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pbplayer.Location.Y >= 475)
            {
                gravity = false;
            }
            else if (pbplayer.Location.Y < 475)
            {
                gravity = true;
            }

            if (cancel == false)
            {
                if (goUp == false & gravity == true & stop == false)
                {
                    pbplayer.Top += gspeed;
                    pbhover.Top += gspeed;
                    pbshield.Top += gspeed;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            int num1 = rand1.Next(0, 364);

            Random rand2 = new Random();
            int num2 = rand1.Next(0, 3);

            if (num2 == 0 & nuke == false)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(58, 186),
                    Location = new Point(1200, num1),
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Properties.Resources.ifo2,
                };
                this.Controls.Add(picture);
                pictureBoxList.Add(picture);
            }
            else if (num2 == 1 & nuke == false)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(78, 41),
                    Location = new Point(1200, num1),
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Properties.Resources.miss,
                };
                this.Controls.Add(picture);
                pictureBoxList.Add(picture);
            }
            else if (num2 == 2 & nuke == false)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(78, 41),
                    Location = new Point(1200, num1),
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Properties.Resources.bom33333,
                };
                this.Controls.Add(picture);
                pictureBoxList.Add(picture);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (stop == false)
            {
                try
                {
                    foreach (var pictureBox in pictureBoxList)
                    {
                        if (nuke == true)
                        {
                            pictureBox.Visible = false;
                        }

                        pictureBox.Left -= espeed;

                        if (pbplayer.Bounds.IntersectsWith(pictureBox.Bounds) & shield == true & nuke == false)
                        {
                            
                            timer9.Start();

                            pbshield.Visible = false;
                            pbshield.Enabled = false;

                            pictureBox.Visible = false;
                            pictureBox.Enabled = false;
                        }

                        if (pbplayer.Bounds.IntersectsWith(pictureBox.Bounds) & shield == false & nuke == false)
                        {

                            if (lives == 3)
                            {
                                timer11.Start();
                                pictureBox.Visible = false;
                                pictureBox.Enabled = false;

                                pblives1.Image = Properties.Resources.heart2;

                            }
                            else if (lives == 2)
                            {
                                timer11.Start();
                                pictureBox.Visible = false;
                                pictureBox.Enabled = false;

                                pblives2.Image = Properties.Resources.heart2;
                            }
                            else if (lives == 1)
                            {
                                lives -= 1;
                                pictureBox.Visible = false;
                                pictureBox.Enabled = false;

                                pblives3.Image = Properties.Resources.heart2;
                            }
                            
                        }

                        if (lives == 0)
                        {
                            stop = true;

                            pictureBox.Visible = false;
                            pictureBox.Enabled = false;

                            //MessageBox.Show("GameOver"); the code below won't run until msgbox is clicked

                            pbplayer.Visible = false;
                            pbhover.Visible = false;

                            pbexplosion.Visible = true;
                            pbexplosion.Enabled = true;
                            pbexplosion.Location = pbplayer.Location;
                            timer7.Start();

                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timer4.Stop();
                            timer5.Stop();
                        }

                    }
                }
                catch
                {
                }

                foreach (var pictureBox in powerupShield)
                {
                    if (nuke == true)
                    {
                        pictureBox.Visible = false;
                    }

                    pictureBox.Left -= espeed;

                    //Point pointresult = new Point(pictureBox.Location.X, pictureBox.Location.Y);
                    //pointresult.Offset(0, 15);

                    if (pbplayer.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        shield = true;

                        pbshield.Visible = true;
                        pbshield.Enabled = true;

                        pictureBox.Visible = false;

                        
                    }
                }

                foreach (var pictureBox in powerupNuke)
                {
                    pictureBox.Left -= espeed;

                    //Point pointresult = new Point(pictureBox.Location.X, pictureBox.Location.Y);
                    //pointresult.Offset(0, 15);

                    if (pbplayer.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        nuke = true;
                        pictureBox.Visible = false;
                        timer10.Start();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Global.score += 1;
            lblscore.Text = Global.score.ToString();

            //- 150 on timer for every increase in value. 1500 / 10 = 150

            if (time >= 10)
            {
                espeed += 1;
                timer3.Interval -= 150;
                time = 0;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            time += 1;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pbexplosion.Visible = false;
            pbexplosion.Enabled = false;


            this.Hide();
            var form3 = new Form3();
            form3.Show();
            form3.Closed += (s, args) => this.Close();

            timer7.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            int num1 = rand1.Next(0, 364);

            Random rand2 = new Random();
            int num2 = rand2.Next(0, 2);

            if (shield == false & num2 == 0 & nuke == false)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(72, 69),
                    Location = new Point(1200, num1),
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Properties.Resources.shieldico
                };
                this.Controls.Add(picture);
                powerupShield.Add(picture);
            }

            if (nuke == false & num2 == 1)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(72, 69),
                    Location = new Point(1200, num1),
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Properties.Resources.nuke
                };
                this.Controls.Add(picture);
                powerupNuke.Add(picture);
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            shield = false;
            timer9.Stop();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            nuke = false;
            timer10.Stop();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            lives -= 1;
            timer11.Stop();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {

        }

        private void timer12_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;


            pblives1.Visible = true;
            pblives2.Visible = true;
            pblives3.Visible = true;

            _lblscore.Visible = true;
            lblscore.Visible = true;

            Global.score = 0;

            timer3.Start();
            timer8.Start();
            timer5.Start();
            timer4.Start();
            timer6.Start();

            timer12.Stop();
        }
    }
}
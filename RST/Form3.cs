using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RST
{
    public partial class Form3 : Form
    {

        string input;

        public Form3()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            label2.Text = Global.score.ToString();
            
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            timer1.Start();
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
            form1.Closed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
            form2.Closed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to add your score to the leaderboards?", "Leaderboards", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                input = Interaction.InputBox("What is your name?", "Name", "Name");
            }

            string path = Environment.CurrentDirectory + "/" + "results.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("");
                sw.WriteLine(input);
                sw.WriteLine(Global.score);
                sw.WriteLine("-------------------------------------------------------------------------------------------");
            }

            this.Hide();
            var form4 = new Form4();
            form4.Show();
            form4.Closed += (s, args) => this.Close();

        }
    }
}

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

namespace RST
{
    public partial class Form4 : Form
    {
        string line1;
        string line2;
        string line3;

        string name1;
        string name2;
        string name3;

        int line11;
        int line12;
        int line13;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            if (Global.btn1 == false)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
  

            try
            {
                line1 = File.ReadLines("results.txt").Skip(2).Take(1).First();
            }
            catch
            {

            }

            try
            {
                line2 = File.ReadLines("results.txt").Skip(6).Take(1).First();
            }
            catch
            {

            }

            try
            {
                line3 = File.ReadLines("results.txt").Skip(10).Take(1).First();
            }
            catch
            {

            }


            try
            {
               name1 = File.ReadLines("results.txt").Skip(1).Take(1).First();
            }
            catch
            {

            }

            try
            {
                name2 = File.ReadLines("results.txt").Skip(5).Take(1).First();
            }
            catch
            {

            }

            try
            {
                name3 = File.ReadLines("results.txt").Skip(9).Take(1).First();
            }
            catch
            {

            }

            try
            {
                line11 = Int32.Parse(line1);
            }
            catch
            {

            }

            try
            {
                line12 = Int32.Parse(line2);
            }
            catch
            {

            }

            try
            {
                line13 = Int32.Parse(line3);
            }
            catch
            {

            }


            if (line11 > line12 & line11 > line13)
            {
                label4.Text = name1;
                label7.Text = line11.ToString();

                if (line12 > line13)
                {
                    label5.Text = name2;
                    label8.Text = line12.ToString();

                    label6.Text = name3;
                    label9.Text = line13.ToString();
                }
                else if (line13 > line12)
                {
                    label5.Text = name3;
                    label8.Text = line13.ToString();

                    label6.Text = name2;
                    label9.Text = line12.ToString();
                }
            }
            else if (line12 > line11 & line12 > line13)
            {
                label4.Text = name2;
                label7.Text = line12.ToString();

                if (line11 > line13)
                {
                    label5.Text = name1;
                    label8.Text = line11.ToString();

                    label6.Text = name3;
                    label9.Text = line13.ToString();
                }
                else if (line13 > line11)
                {
                    label5.Text = name3;
                    label8.Text = line13.ToString();

                    label6.Text = name3;
                    label9.Text = line11.ToString();
                }

            }
            else if (line13 > line11 & line13 > line12)
            {
                label4.Text = name3;
                label7.Text = line13.ToString();

                if (line11 > line12)
                {
                    label5.Text = name1;
                    label8.Text = line11.ToString();

                    label6.Text = name3;
                    label9.Text = line12.ToString();
                }
                else if (line12 > line11)
                {
                    label5.Text = name2;
                    label8.Text = line12.ToString();

                    label6.Text = name1;
                    label9.Text = line11.ToString();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
            form1.Closed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
            form2.Closed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
            form3.Closed += (s, args) => this.Close();
        }
    }
}

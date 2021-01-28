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
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string line1 = File.ReadLines("results.txt").Skip(2).Take(1).First();
            string line2 = File.ReadLines("results.txt").Skip(6).Take(1).First();
            string line3 = File.ReadLines("results.txt").Skip(10).Take(1).First();

            string name1 = File.ReadLines("results.txt").Skip(1).Take(1).First();
            string name2 = File.ReadLines("results.txt").Skip(5).Take(1).First();
            string name3 = File.ReadLines("results.txt").Skip(9).Take(1).First();

            int line11 = Int32.Parse(line1);
            int line12 = Int32.Parse(line2);
            int line13 = Int32.Parse(line3);

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

                    label6.Text = name3;
                    label9.Text = line11.ToString();
                }

            }


        }
    }
}

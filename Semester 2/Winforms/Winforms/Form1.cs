using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button_SomethingUseful.MouseEnter += (o, e) => Changecolor(Color.BlanchedAlmond);
            Button_SomethingUseful.MouseLeave += (o, e) => Changecolor(Color.Plum);
        }
        public void Changecolor(Color c)
        {
            Button_SomethingUseful.BackColor = c;
        }
        private void SomethingUseful_Click(object sender, EventArgs e)
        {
            if (checkBox_FailSafe.Checked && dateTimePicker_doomsDay.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap B = new Bitmap(pictureBox_box.Width, pictureBox_box.Height);
                Random rand = new Random();
                for(int x=0; x<pictureBox_box.Width;x++)
                {
                    for(int y=0; y<pictureBox_box.Height; y++)
                    {
                        B.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Black: Color.Blue);
                    }
                }
                pictureBox_box.Image = B;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
            if(textBox1.Text == "Hammer Time")
            {
                pictureBox_box.Image = Properties.Resources.HammerTime;
            }
            if (textBox1.Text == "Kill all humans!" || textBox1.Text == "KILL ALL HUMANS!")
            {
                pictureBox_box.Image = Properties.Resources.KillAllHumans;
            }
            if (textBox1.Text == "Floof" || textBox1.Text == "floof"|| textBox1.Text == "Shoop" || textBox1.Text == "shoop")
            {
                pictureBox_box.Image = Properties.Resources.floof;
            }
        }

        private void pictureBox_box_Click(object sender, EventArgs e)
        {
            if (checkBox_FailSafe.Checked)
            {
                pictureBox_box.Image = Properties.Resources.explosion;
                pictureBox_box.Refresh();
            }
        }

        private void checkBox_FailSafe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_FailSafe.Checked)
            {
                pictureBox_box.Image = Properties.Resources.DoNotPress;
                pictureBox_box.Refresh();
                pictureBox_box.Visible = true;
            }
        }
    }
}

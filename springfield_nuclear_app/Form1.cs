using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace springfield_nuclear_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool meltdown_happening = false;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void reactor1_button_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (meltdown_happening) {
                reactor1_button.BackColor = Color.White;
                reactor2_button.BackColor = Color.White;

                reactor_status_text.Text = "Reactors are Ok";

                meltdown_happening = false;
            } else {
                SoundPlayer test = new SoundPlayer;


                reactor1_button.BackColor = Color.Red;
                reactor2_button.BackColor = Color.Red;
                meltdown_happening = true;

                System.Threading.Thread.Sleep(750);



                //System.Media.SoundPlayer sound = new SoundPlayer;

                reactor_status_text.Text = "Reaactors are Not Ok";
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

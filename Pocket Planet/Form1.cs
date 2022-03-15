using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Planet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Start();
            //pcb_start.Load("https://i.pinimg.com/originals/c7/1b/ee/c71beee0137ed81258c939bbc23af086.gif");
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            //form2.ThePicture = this.pb_Simulation;
            this.pb_Simulation.Image = null;

        }
        private bool ready = false;
        public int messenger = 0;
        public string imgpath = "";
        public int ccount = 0;
        public int gentype = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_message.Text = Convert.ToString(messenger);
            if (messenger == 0)
            {
                pcb_start.Visible = true;
                lbl_message.Visible = true;

                lbl_set.Visible = false;
                lbl_mset.Visible = false;
                lbl_cset.Visible = false;
                lbl_ccount.Visible = false;
                btn_openImg.Visible = false;
                rbtn_generateMap.Visible = false;
                rbtn_loadMap.Visible = false;
                pb_launch.Visible = false;
                gb_map.Visible = false;

                gb_ccount.Visible = false;
                rbtn_p3.Visible = false;
                rbtn_p4.Visible = false;
                rbtn_p5.Visible = false;
                rbtn_p6.Visible = false;
                rbtn_p7.Visible = false;
                rbtn_p8.Visible = false;

                gb_countries.Visible = false;
                cb_agressive.Visible = false;
                cb_peacekeeper.Visible = false;
                cb_green_movement.Visible = false;
                cb_hard_terrain.Visible = false;

                gb_generate.Visible = false;
            }
            else if (messenger == 1)
            {
                pcb_start.Visible = false;
                lbl_message.Visible = true;

                lbl_set.Visible = true;
                lbl_mset.Visible = true;
                lbl_cset.Visible = true;
                lbl_ccount.Visible = true;
                rbtn_generateMap.Visible = true;
                rbtn_loadMap.Visible = true;
                //pb_launch.Visible = true;

                gb_countries.Visible = true;
                cb_agressive.Visible = true;
                cb_peacekeeper.Visible = true;
                cb_green_movement.Visible = true;
                cb_hard_terrain.Visible = true;

                gb_ccount.Visible = true;
                rbtn_p3.Visible = true;
                rbtn_p4.Visible = true;
                rbtn_p5.Visible = true;
                rbtn_p6.Visible = true;
                rbtn_p7.Visible = true;
                rbtn_p8.Visible = true;

                if (ready)
                {
                    lbl_openMapStatus.Text = "Ready " + ccount;
                }

                if (rbtn_loadMap.Checked)
                {
                    gb_map.Visible = true;
                    btn_openImg.Visible = true;

                }
                else
                {
                    gb_map.Visible = false;
                    btn_openImg.Visible = false;
                }

                if (rbtn_generateMap.Checked)
                {
                    gb_generate.Visible = true;
                }
                else
                {
                    gb_generate.Visible = false;
                }
            }
            else
            {
            }
        }

        //#0
        private void pcb_start_Click(object sender, EventArgs e)
        {
            messenger = 1;
        }

        private void btn_openImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pb_Simulation.ImageLocation = openFileDialog1.FileName;
            imgpath = openFileDialog1.FileName;
            ready = true;
            pb_launch.Visible = true;
        }

        private void pb_launch_Click(object sender, EventArgs e)
        {
            Form2 to = new Form2();
            to.Show();
            Form3 to2 = new Form3();
            to2.Show();
            if (rbtn_loadMap.Checked)
            {
                gentype = -1;
            }
            messenger = 2;
            this.Hide();
            to2.Hide();

        }

        private void rbtn_p3_CheckedChanged(object sender, EventArgs e)
        {
            ccount = 3;
        }

        private void rbtn_p4_CheckedChanged(object sender, EventArgs e)
        {
            ccount = 4;
        }

        private void rbtn_p5_CheckedChanged(object sender, EventArgs e)
        {
            ccount = 5;
        }

        private void rbtn_p6_CheckedChanged(object sender, EventArgs e)
        {
            ccount = 6;
        }

        private void rbtn_p7_CheckedChanged(object sender, EventArgs e)
        {
            ccount = 7;
        }

        private void rbtn_p8_CheckedChanged(object sender, EventArgs e)
        {
            ccount = 8;
        }



        /*
private PictureBox _thePicture;
public PictureBox ThePicture
{
set { this._thePicture = value; }
get { return this._thePicture; }
}
*/


        //#1









        /*
string path = @"C:\Users\ASUS ROG\Pictures\Saved Pictures\spfere.gif";
Bitmap map = new Bitmap(@"C: \Users\ASUS ROG\Pictures\Saved Pictures", true);*/



    }
}

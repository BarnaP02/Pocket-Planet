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
    public partial class Form2 : Form
    {
        int x = 0;
        int y = 0;
        int log = 0;
        //Bitmap temp;
        public string path = "";
        public int messenger2 = 0;
        public Form2()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
            pb_Simulation.Image = new Bitmap(pb_Simulation.Width, pb_Simulation.Height);       //((Form1)f).Width, ((Form1)f).Height);
            tmr_Lup.Interval = 1;
            lbl_log3.Text = Convert.ToString(log);
            lbl_log.Text = Convert.ToString(pb_Simulation.Width);
            lbl_log2.Text = Convert.ToString(pb_Simulation.Height);
            tmr_Lup.Start();
            tmr_paint.Interval = 100;
            //tmr_paint.Start();

            //g = pb_Simulation.CreateGraphics();


            bm = new Bitmap(pb_Simulation.Width, pb_Simulation.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pb_Simulation.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        List<List<int>> HeightMatrix = new List<List<int>>();
        List<int> tempHM = new List<int>();
        int index;

        private void tmr_Lup_Tick(object sender, EventArgs e)
        {
            lbl_log3.Text =Convert.ToString(log);
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];

            //pb_Simulation.ImageLocation = ((Form1)f).imgpath;

            if (((Form1)f).messenger==2)//(messenger2==0) //
            {
                ((Form1)f).messenger = 3;
                messenger2 = 1;
                //((Form1)f).Close();
                //temp.Width = pb_Simulation.Width;
                //temp.Height = pb_Simulation.Height;
                //temp = new Bitmap(pb_Simulation.Image);
                path = ((Form1)f).imgpath;
                Bitmap newmap = new Bitmap(path,true);
                //newmap.Width = 1290;
                tmr_Lup.Stop();
                int grey = 0;

                //////ez jo \/
                
                for (int i = 1; i < 1290; i++)
                {
                    for (int j = 1; j < 750; j++)
                    {
                        x = i;
                        y = j;
                        //lbl_log3.Text = Convert.ToString(Height - y);
                        //Color clr = ((Bitmap)pb_Simulation.Image).GetPixel(x, y);
                        Color clr = newmap.GetPixel(x, y);
                        grey = (clr.R + clr.G + clr.B) / 3;
                        Color newclr = Color.FromArgb(grey, grey, grey);
                        //((Bitmap)pb_Simulation.Image).SetPixel(x, y, newclr);
                        //
                        newmap.SetPixel(x, y, newclr);
                        //
                        px.X = x;
                        px.Y = y;
                        p.Color = newclr;
                        g.DrawLine(p, px, py);
                        py = px;

                        //pb_Simulation.Refresh();
                        lbl_log.Text = Convert.ToString(x);
                        lbl_log2.Text = Convert.ToString(y);
                        log++;
                    }
                    pb_Simulation.Refresh();
                }
                tmr_Lup.Start();
                pb_Simulation.Image = newmap;
                pb_Simulation.Refresh();
                
                /////////////////////////////
            }

            if (messenger2==1)
            {
                messenger2 = 2;
                Bitmap newmap = new Bitmap(pb_Simulation.Image);
                pb_Simulation.Refresh();
                int tValue = 0;
                lbl_log5.Text = Convert.ToString(messenger2);
                Color clr;
                Color newclr;
                int grey=0;
                tmr_Lup.Stop();
                /*
                for (int i = 0; i < 43; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        for (int l = 0; l < 29; l++)
                        {
                            for (int k = 0; k < 29; k++)
                            {
                                clr = newmap.GetPixel(30*i + l, 30*j + k);
                                tValue += clr.R;
                            }
                        }
                        lbl_log4.Text = Convert.ToString(tValue);
                        newclr = Color.FromArgb(tValue/900, tValue / 900, tValue / 900);
                        for (int l = 0; l < 29; l++)
                        {
                            for (int k = 0; k < 29; k++)
                            {
                                newmap.SetPixel(30*i + l, 30*j + k, newclr);
                            }
                        }
                        tValue = 0;
                    pb_Simulation.Refresh();
                    }
                }
                */

                ////ez jo \/
                
                for (int i = 0; i < 258; i++)
                {
                    for (int j = 0; j < 150; j++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                clr = newmap.GetPixel(5 * i + l, 5 * j + k);
                                tValue += clr.R;
                            }
                        }
                        lbl_log4.Text = Convert.ToString(tValue);
                        newclr = Color.FromArgb(tValue / 25, tValue / 25, tValue / 25);
                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                newmap.SetPixel(5 * i + l, 5 * j + k, newclr);
                            }
                        }
                        tValue = 0;
                        pb_Simulation.Refresh();
                    }
                }
                
                //////////////////////////////meg nem jo////////////////////ezzel még nem szinezi ki////////////////////de a matrix az elvileg jo//////////bar meg nem biztos//////////////
                /*
                for (int i = 0; i < 258; i++)
                {
                    for (int j = 0; j < 150; j++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                x = i;
                                y = j;
                                clr = newmap.GetPixel(x, y);
                                grey = (clr.R + clr.G + clr.B) / 3;
                                newclr = Color.FromArgb(grey, grey, grey);
                                //clr = newmap.GetPixel(5 * i + l, 5 * j + k);
                                tValue += grey;
                            }
                        }
                        lbl_log4.Text = Convert.ToString(tValue);
                        newclr = Color.FromArgb(tValue / 25, tValue / 25, tValue / 25);
                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                px.X = x;
                                px.Y = y;
                                p.Color = newclr;
                                g.DrawLine(p, px, py);
                                py = px;
                                //newmap.SetPixel(5 * i + l, 5 * j + k, newclr);
                                tempHM.Add(grey/25);
                            }
                        }
                        tValue = 0;
                        HeightMatrix.Add(tempHM);
                        pb_Simulation.Refresh();
                    }
                }
                lbl_log5.Text = Convert.ToString(HeightMatrix[100][100]);
                */
                tmr_Lup.Start();
                pb_Simulation.Image = newmap;
                pb_Simulation.Refresh();
            }

        }


        /*private void tmr_paint_Tick(object sender, EventArgs e)
        {
            Color clr = ((Bitmap)pb_Simulation.Image).GetPixel(x, y);
            Color newclr = Color.FromArgb(clr.R, 0, 0);
            ((Bitmap)pb_Simulation.Image).SetPixel(x, y, newclr);
            pb_Simulation.Refresh();
            lbl_log.Text = Convert.ToString(x);
            lbl_log2.Text = Convert.ToString(y);
            log++;
            lbl_log3.Text = Convert.ToString(log);
            if (x < y - 1)
            {
                x++;
            }
            else if (y < pb_Simulation.Height - 1)
            {
                x = 0;
                y++;
            }
            else
            {
                tmr_paint.Stop();
            }
        }*/
        /*
public PictureBox ThePicture
{
get { return this.pb_Simulation; }
}
*/

    }
}

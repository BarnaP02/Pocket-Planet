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
        //int[,] Matrix = new int[86, 50];     //
        int[,] Matrix = new int[1290, 750];
        string[,] Map = new string[1290, 750];
        int ccount;
        Random rnd = new Random();
        Bitmap newmap;
        int szamlalo = 0;
        int mapwidth = 1290;
        int mapheight = 750;
        bool van_szomszed = false;
        bool border = false;
        string ProgressCol = "0";
        bool converted = false;
        int lefutott = 0;
        int szamlaloossz = 0;

        private void tmr_Lup_Tick(object sender, EventArgs e)
        {
            lbl_log3.Text ="log: " + Convert.ToString(log);
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];

            //pb_Simulation.ImageLocation = ((Form1)f).imgpath;

            if (((Form1)f).messenger==2)//(messenger2==0) //
            {
                ((Form1)f).messenger = 3;
                ccount = ((Form1)f).ccount;
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
                pb_Simulation.Image = newmap;

                //////ez jo \/
                
                for (int i = 0; i < 1290; i++)
                {
                    for (int j = 0; j < 750; j++)
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
                        lbl_log.Text = "X: " + Convert.ToString(x);
                        lbl_log2.Text = "Y: " + Convert.ToString(y);
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
                newmap = new Bitmap(pb_Simulation.Image);
                pb_Simulation.Refresh();
                int tValue = 0;
                lbl_log5.Text = "messenger2: " + Convert.ToString(messenger2);
                Color clr;
                Color newclr;
                int grey=0;
                tmr_Lup.Stop();
                szamlaloossz = ccount;
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
                
                for (int i = 0; i < 258; i++) // (int i = 0; i < 1290; i++)
                {
                    for (int j = 0; j < 150; j++) // (int j = 0; j < 750; j++)
                    {                        
                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                clr = newmap.GetPixel(5 * i + l, 5 * j + k); // newmap.GetPixel(i, j);
                                tValue += clr.R;
                                Matrix[5 * i + l, 5 * j + k] = clr.R/25; // Matrix[i, j] = clr.R;
                                Map[5 * i + l, 5 * j + k] = Convert.ToString(clr.R/25); // Map[i, j] = Convert.ToString(clr.R/25);
                                int test = int.Parse(Map[5 * i + l, 5 * j + k]); // int.Parse(Map[i, j]);
                                if (test < 6)
                                {
                                    //Map[5 * i + l, 5 * j + k] = "-1"; //  Map[i, j] = "-1";
                                }
                            }
                        }
                        
                        //////////
                        /*
                        clr = newmap.GetPixel(i,j);
                        tValue += clr.R;
                        Matrix[i, j] = clr.R;
                        * /
                        lbl_log4.Text = Convert.ToString(tValue);
                        newclr = Color.FromArgb(tValue / 25, tValue / 25, tValue / 25);

                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                newmap.SetPixel(5 * i + l, 5 * j + k, newclr);
                                Matrix[i, j] = newclr.R;
                                Map[i, j] = Convert.ToString(newclr.R);
                            }
                        }
                        
                        ////////////
                        /*
                        newmap.SetPixel(i,j, newclr);
                        Matrix[i, j] = newclr.R;
                        Map[i, j] = Convert.ToString(newclr.R);
                        */
                        tValue = 0;
                        pb_Simulation.Refresh();
                    }
                    //pb_Simulation.Image = newmap;
                }
                // * /
                //////////////////////////////meg nem jo////////////////////ezzel még nem szinezi ki////////////////////de a matrix az elvileg jo//////////bar meg nem biztos//////////////
                /*
                pb_Simulation.Image = newmap;
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
                                //newclr = Color.FromArgb(grey, grey, grey);
                                //clr = newmap.GetPixel(5 * i + l, 5 * j + k);
                                tValue += grey;
                            }
                        }
                        lbl_log4.Text = Convert.ToString(tValue);
                        newclr = Color.FromArgb(tValue / 25, tValue / 25, tValue / 25);
                        lbl_log3.Text = "newclr: (" + Convert.ToString(tValue/25) + "," + Convert.ToString(tValue/25) + "," + Convert.ToString(tValue/25) + ")";
                        for (int l = 0; l < 5; l++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                x = i;
                                y = j;
                                px.X = x;
                                px.Y = y;
                                p.Color = newclr;
                                g.DrawLine(p, px, py);
                                py = px;
                                //newmap.SetPixel(5 * i + l, 5 * j + k, newclr);
                                tempHM.Add(grey/25);
                                pb_Simulation.Refresh();
                            }
                        }
                        tValue = 0;
                        HeightMatrix.Add(tempHM);
                        pb_Simulation.Refresh();
                    }
                    if (i==30)
                    {
                        //////////////
                        this.Hide();
                        //////////////
                    }
                }
                lbl_log5.Text = "HM: " + Convert.ToString(HeightMatrix[100][100]);
                */
                ///////////////////////////////////////////////////////////70 perces cucc vege//////////////////////////

                /*
                pb_Simulation.Image = newmap;
                for (int i = 0; i < 86; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        for (int l = 0; l < 15; l++)
                        {
                            for (int k = 0; k < 15; k++)
                            {
                                x = i;
                                y = j;
                                clr = newmap.GetPixel(x, y);
                                grey = (clr.R + clr.G + clr.B) / 3;
                                //newclr = Color.FromArgb(grey, grey, grey);
                                //clr = newmap.GetPixel(5 * i + l, 5 * j + k);
                                tValue += grey;
                            }
                        }
                        lbl_log4.Text = Convert.ToString(tValue);
                        newclr = Color.FromArgb(tValue / 225, tValue / 225, tValue / 225);
                        lbl_log3.Text = "newclr: (" + Convert.ToString(tValue / 225) + "," + Convert.ToString(tValue / 225) + "," + Convert.ToString(tValue / 225) + ")";
                        for (int l = 0; l < 15; l++)
                        {
                            for (int k = 0; k < 15; k++)
                            {
                                x = i;
                                y = j;
                                px.X = x;
                                px.Y = y;
                                p.Color = newclr;
                                g.DrawLine(p, px, py);
                                py = px;
                                //newmap.SetPixel(5 * i + l, 5 * j + k, newclr);
                                //tempHM.Add(grey / 25);
                                Matrix[i,j] = grey / 225;
                                pb_Simulation.Image = newmap;
                                pb_Simulation.Refresh();
                            }
                        }
                        tValue = 0;
                        //HeightMatrix.Add(tempHM);
                        pb_Simulation.Refresh();
                    }
                    if (i == 5)
                    {
                        //////////////
                        //this.Hide();
                        //////////////
                    }
                }
                lbl_log5.Text = "HM: " + Convert.ToString(Matrix[50,25]);

                tmr_Lup.Start();
                pb_Simulation.Image = newmap;
                pb_Simulation.Refresh();
            */
                lbl_log4.Text = "Map[50, 25]: " + Convert.ToString(Matrix[50, 25]);
                lbl_log5.Text = "HM: " + Convert.ToString(Matrix[50, 25]);
                string checker="";
                int cx = 0;
                int cy = 0;
                for (int i = 0; i < ccount; i++)
                {
                    cx = rnd.Next(1, 1291);
                    cy = rnd.Next(1, 750);
                    Map[cx - 1, cy - 1] = Convert.ToString(i + 2) + Convert.ToString(i + 2);
                    //checker += $"Map[{cx},{cy}]: {Map[cx, cy]} \t";
                    checker += $"{cx} ";
                }
                for (int i = 0; i < ccount; i++)
                {
                    cx = rnd.Next(1, 1291);
                    cy = rnd.Next(1, 750);
                    Map[cx - 1, cy - 1] = Convert.ToString(i + 2) + Convert.ToString(i + 2);
                    //checker += $"Map[{cx},{cy}]: {Map[cx, cy]} \t";
                    checker += $"{cx} ";
                }
                lbl_log4.Text = "W " + Convert.ToString(pb_Simulation.Width);
                lbl_log5.Text = "H " + Convert.ToString(pb_Simulation.Height);
                checker += $"Map[{cx},{cy}]: {Map[cx, cy]}";
                lbl_log5.Text = checker;
                lbl_log6.Text = $"Map[{3},{3}]: {Map[3, 3]}";
                RefreshTheMap2();
                for (int p = 0; p < 400; p++) //100 biztos elég egy sötétebb képpel sok országgal de egy világos képen 3 országgal lehet hogy az 1000 is kevés
                {
                    //while (mapwidth*mapheight - ccount > szamlaloossz)
                    {
                        lefutott++;
                        InquisitionE();
                    }
                    if (lefutott % 10 == 0) 
                    {
                        RefreshTheMap2();
                    }
                }
                lbl_log6.Text = $"w*h: {mapwidth * mapheight}, sz: {ccount + szamlalo}";
                lbl_log4.Text = $"lefutott: {lefutott}";
                /*
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                InquisitionE();
                */
                /*
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                Inquisition();
                */
                /*
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                InquisitionU();
                */
                /*
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                InquisitionV();
                */
                //RefreshTheMap();
                RefreshTheMap2();
            }
        }
        public void RefreshTheMap() //csak a képet frissiti a terkep alapjan
        {
            Color refrclr = Color.FromArgb(0, 0, 0);
            for (int i = 1; i < pb_Simulation.Width-1; i++)
            {
                for (int j = 1; j < pb_Simulation.Height-1; j++)
                {
                    if (Map[i, j] == "-1") 
                    {
                        refrclr = Color.FromArgb(0,0,0);
                    }
                    else if (Map[i, j] == "44")
                    {
                        refrclr = Color.FromArgb(255, 0, 0);
                    }
                    else if (Map[i, j] == "55")
                    {
                        refrclr = Color.FromArgb(0, 255, 0);
                    }
                    else if (Map[i, j] == "66")
                    {
                        refrclr = Color.FromArgb(0, 0, 255);
                    }
                    else if (Map[i, j] == "77")
                    {
                        refrclr = Color.FromArgb(255, 255, 0);
                    }
                    else if (Map[i, j] == "88")
                    {
                        refrclr = Color.FromArgb(0, 255, 255);
                    }
                    else if (Map[i, j] == "99") //Convert.ToString(88))
                    {
                        refrclr = Color.FromArgb(255, 0, 255);
                    }
                    else //if (Map[i, j] == Convert.ToString(99))
                    {
                        refrclr = newmap.GetPixel(i,j);
                    }
                    x = i;
                    y = j;
                    px.X = x;
                    px.Y = y;
                    p.Color = refrclr;
                    //g.DrawLine(p, px, py);
                    newmap.SetPixel(i, j, refrclr);
                    py = px;
                    pb_Simulation.Image = newmap;

                }
            }
            pb_Simulation.Refresh();
            lbl_log6.Text += " donezo";
            lbl_log6.Text += Convert.ToString(Map[3, 4]);
        }
        public void RefreshTheMap2() //csak a képet frissiti a terkep alapjan
        {
            Color refrclr = Color.FromArgb(0, 0, 0);
            for (int i = 0; i < pb_Simulation.Width - 1; i++)
            {
                for (int j = 0; j < pb_Simulation.Height - 1; j++)
                {
                            if (Map[i, j] == "-1")
                            {
                                refrclr = Color.FromArgb(0, 0, 0);
                            }
                            else if (Map[i, j] == "22")
                            {
                                refrclr = Color.FromArgb(243, 114, 32);
                            }
                            else if (Map[i, j] == "33")
                            {
                                refrclr = Color.FromArgb(149, 0, 255);
                            }
                            else if (Map[i, j] == "44")
                            {
                                refrclr = Color.FromArgb(255, 0, 0);
                            }
                            else if (Map[i, j] == "55")
                            {
                                refrclr = Color.FromArgb(0, 255, 0);
                            }
                            else if (Map[i, j] == "66")
                            {
                                refrclr = Color.FromArgb(0, 0, 255);
                            }
                            else if (Map[i, j] == "77")
                            {
                                refrclr = Color.FromArgb(255, 255, 0);
                            }
                            else if (Map[i, j] == "88")
                            {
                                refrclr = Color.FromArgb(0, 255, 255);
                            }
                            else if (Map[i, j] == "99") //Convert.ToString(88))
                            {
                                refrclr = Color.FromArgb(255, 0, 255);
                            }
                            else //if (Map[i, j] == Convert.ToString(99))
                            {
                                refrclr = newmap.GetPixel(i, j);
                            }
                    //for (int k = 1; k < 5; k++)
                    {
                        //for (int l = 1; l < 5; l++)
                        {
                            x = i;
                            y = j;
                            px.X = x;
                            px.Y = y;
                            p.Color = refrclr;
                            //g.DrawLine(p, px, py);
                            newmap.SetPixel(i, j, refrclr);  //  newmap.SetPixel(5 * i + l, 5 * j + k, refrclr);
                            py = px;
                            pb_Simulation.Image = newmap;

                        }
                    }

                }
            }
            pb_Simulation.Refresh();
            lbl_log6.Text += " donezo2";
            lbl_log6.Text += Convert.ToString(Map[3, 4]);
        }

        public void Inquisition()
        {
            for (int i = 1; i < pb_Simulation.Width + 1; i++)
            {
                for (int j = 1; j < pb_Simulation.Height + 1; j++)
                {
                    if (i == 1 && j == 1) // bal felso
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (Map[i + 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i + 1, j]);
                                van_szomszed = true;
                            }
                            if (Map[i, j + 1] != Map[i, j])
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j + 1]);
                            }
                        }
                    }
                    if (i == pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // jobb also
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (Map[i - 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i - 1, j]);
                                van_szomszed = true;
                            }
                            if (Map[i, j - 1] != Map[i, j])
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j - 1]);
                            }
                        }
                    }
                    if (i == pb_Simulation.Width - 1 && j == 1) // jobb felso
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (Map[i - 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i - 1, j]);
                                van_szomszed = true;
                            }
                            if (Map[i, j + 1] != Map[i, j])
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j + 1]);
                            }
                        }
                    }
                    if (i == 1 && j == pb_Simulation.Height - 1) // bal also
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (Map[i + 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i + 1, j]);
                                van_szomszed = true;
                            }
                            if (Map[i, j - 1] != Map[i, j])
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j - 1]);
                            }
                        }
                    }
                    if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // bal fal
                    {
                        if (Map[i + 1, j] != Map[i, j])
                        {
                            Progressor(i, j, Map[i + 1, j]);
                            van_szomszed = true;
                        }
                        if (Map[i, j + 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                            van_szomszed = true;
                        }
                        if (Map[i, j - 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                        }
                    }
                    if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // jobb fal
                    {
                        if (Map[i - 1, j] != Map[i, j])
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (Map[i, j + 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                            van_szomszed = true;
                        }
                        if (Map[i, j - 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                        }
                    }
                    if (i > 1 && i < pb_Simulation.Width - 1 && j == 1)   // felso fal
                    {
                        if (Map[i - 1, j] != Map[i, j])
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (Map[i, j + 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                            van_szomszed = true;
                        }
                        if (Map[i + 1, j] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i + 1, j]);
                        }
                    }
                    if (i > 1 && i < pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // also fal
                    {
                        if (Map[i - 1, j] != Map[i, j])
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (Map[i, j - 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                            van_szomszed = true;
                        }
                        if (Map[i + 1, j] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i + 1, j]);
                        }
                    }
                    if (i > 1 && i < pb_Simulation.Width - 1 && j > 1 && j < pb_Simulation.Height - 1) // maradek
                    {
                        if (Map[i, j - 1] != Map[i, j])
                        {
                            Progressor(i, j, Map[i, j - 1]);
                            van_szomszed = true;
                        }
                        if (Map[i - 1, j] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (Map[i + 1, j] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i + 1, j]);
                            van_szomszed = true;
                        }
                        if (Map[i, j + 1] != Map[i, j])
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                        }
                    }
                    if (border)
                    {
                        Map[i, j] = "-1";
                    }
                    van_szomszed = false;
                    border = false;
                }
            }
        }
        public void InquisitionE()
        {
            szamlalo = 0;
            for (int i = 0; i < pb_Simulation.Width; i++)
            {
                for (int j = 0; j < pb_Simulation.Height; j++)
                {
                    if (int.Parse(Map[i, j])< 11)
                    {
                        converted = false;
                        ProgressCol = "";
                        if (i == 1 && j == 1) // bal felso
                        {
                            if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                            {
                                if (Map[i + 1, j] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i + 1, j]);
                                }
                                if (Map[i, j + 1] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i, j + 1]);
                                }
                            }
                        }
                        else if (i == pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // jobb also
                        {
                            if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                            {
                                if (Map[i - 1, j] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i - 1, j]);
                                }
                                if (Map[i, j - 1] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i, j - 1]);
                                }
                            }
                        }
                        else if (i == pb_Simulation.Width - 1 && j == 1) // jobb felso
                        {
                            if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                            {
                                if (Map[i - 1, j] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i - 1, j]);
                                }
                                if (Map[i, j + 1] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i, j + 1]);
                                }
                            }
                        }
                        else if (i == 1 && j == pb_Simulation.Height - 1) // bal also
                        {
                            if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                            {
                                if (Map[i + 1, j] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i + 1, j]);
                                }
                                if (Map[i, j - 1] != Map[i, j])
                                {
                                    Progressor(i, j, Map[i, j - 1]);
                                }
                            }
                        }
                        else if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // bal fal
                        {
                            if (Map[i + 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i + 1, j]);
                            }
                            if (Map[i, j + 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j + 1]);
                            }
                            if (Map[i, j - 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j - 1]);
                            }
                        }
                        else if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // jobb fal
                        {
                            if (Map[i - 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i - 1, j]);
                            }
                            if (Map[i, j + 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j + 1]);
                            }
                            if (Map[i, j - 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j - 1]);
                            }
                        }
                        else if (i > 1 && i < pb_Simulation.Width - 1 && j == 1)   // felso fal
                        {
                            if (Map[i - 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i - 1, j]);
                            }
                            if (Map[i, j + 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j + 1]);
                            }
                            if (Map[i + 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i + 1, j]);
                            }
                        }
                        else if (i > 1 && i < pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // also fal
                        {
                            if (Map[i - 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i - 1, j]);
                            }
                            if (Map[i, j - 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j - 1]);
                            }
                            if (Map[i + 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i + 1, j]);
                            }
                        }
                        else if (i > 1 && i < pb_Simulation.Width - 1 && j > 1 && j < pb_Simulation.Height - 1) // maradek
                        {
                            if (Map[i - 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i - 1, j]);
                            }
                            if (Map[i, j - 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j - 1]);
                            }
                            if (Map[i + 1, j] != Map[i, j])
                            {
                                Progressor(i, j, Map[i + 1, j]);
                            }
                            if (Map[i, j + 1] != Map[i, j])
                            {
                                Progressor(i, j, Map[i, j + 1]);
                            }
                        }
                    if (converted)
                    {
                        szamlalo++;
                    }
                    van_szomszed = false;
                    border = false;
                    }
                    /*
                    if (border)
                    {
                        Map[i, j] = "-1";
                    }
                    */
                }
            }
            szamlaloossz += szamlalo;
        }
        public void InquisitionU()
        {
            for (int i = 1; i < pb_Simulation.Width + 1; i++)
            {
                for (int j = 1; j < pb_Simulation.Height + 1; j++)
                {
                    if (i == 1 && j == 1) // bal felso
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i + 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i + 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j + 1]) > 10)
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j + 1]);
                            }
                        }
                    }
                    if (i == pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // jobb also
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i - 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i - 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j - 1]) > 10)
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j - 1]);
                            }
                        }
                    }
                    if (i == pb_Simulation.Width - 1 && j == 1) // jobb felso
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i - 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i - 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j + 1]) > 10)
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j + 1]);
                            }
                        }
                    }
                    if (i == 1 && j == pb_Simulation.Height - 1) // bal also
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i + 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i + 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j - 1]) > 10)
                            {
                                if (van_szomszed)
                                {
                                    border = true;
                                }
                                Progressor(i, j, Map[i, j - 1]);
                            }
                        }
                    }
                    if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // bal fal
                    {
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i + 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                        }
                    }
                    if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // jobb fal
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                        }
                    }
                    if (i > 1 && i < pb_Simulation.Width - 1 && j == 1)   // felso fal
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i + 1, j]);
                        }
                    }
                    if (i > 1 && i < pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // also fal
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i + 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                        }
                    }
                    if (i > 1 && i < pb_Simulation.Width - 1 && j > 1 && j < pb_Simulation.Height - 1) // maradek
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j - 1]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i + 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            if (van_szomszed)
                            {
                                border = true;
                            }
                            Progressor(i, j, Map[i, j + 1]);
                        }
                    }
                    if (border)
                    {
                        Map[i, j] = "-1";
                    }
                    van_szomszed = false;
                    border = false;
                }
            }
        }
        public void InquisitionV()
        {
            ProgressCol = "";
            for (int i = 1; i < pb_Simulation.Width + 1; i++)
            {
                for (int j = 1; j < pb_Simulation.Height + 1; j++)
                {
                    if (i == 1 && j == 1) // bal felso
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i + 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i + 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j + 1]) > 10)
                            {
                                Progressor(i, j, Map[i, j + 1]);
                                if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                                {
                                    border = true;
                                }
                            }
                        }
                    }
                    else if (i == pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // jobb also
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i - 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i - 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j - 1]) > 10)
                            {
                                Progressor(i, j, Map[i, j - 1]);
                                if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                                {
                                    border = true;
                                }
                            }
                        }
                    }
                    else if (i == pb_Simulation.Width - 1 && j == 1) // jobb felso
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i - 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i - 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j + 1]) > 10)
                            {
                                Progressor(i, j, Map[i, j + 1]);
                                if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                                {
                                    border = true;
                                }
                            }
                        }
                    }
                    else if (i == 1 && j == pb_Simulation.Height - 1) // bal also
                    {
                        if (int.Parse(Map[i, j]) > -1 && int.Parse(Map[i, j]) < 11)
                        {
                            if (int.Parse(Map[i + 1, j]) > 10)
                            {
                                Progressor(i, j, Map[i + 1, j]);
                                van_szomszed = true;
                            }
                            if (int.Parse(Map[i, j - 1]) > 10)
                            {
                                Progressor(i, j, Map[i, j - 1]);
                                if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                                {
                                    border = true;
                                }
                            }
                        }
                    }
                    else if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // bal fal
                    {
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i + 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j + 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j - 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                        }
                    }
                    else if (i == 1 && j > 1 && j < pb_Simulation.Height - 1) // jobb fal
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j + 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j - 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                        }
                    }
                    else if (i > 1 && i < pb_Simulation.Width - 1 && j == 1)   // felso fal
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j + 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i + 1, j]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                        }
                    }
                    else if (i > 1 && i < pb_Simulation.Width - 1 && j == pb_Simulation.Height - 1) // also fal
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i + 1, j]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j - 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                        }
                    }
                    else if (i > 1 && i < pb_Simulation.Width - 1 && j > 1 && j < pb_Simulation.Height - 1) // maradek
                    {
                        if (int.Parse(Map[i - 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i - 1, j]);
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j - 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j - 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i + 1, j]) > 10)
                        {
                            Progressor(i, j, Map[i + 1, j]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                            van_szomszed = true;
                        }
                        if (int.Parse(Map[i, j + 1]) > 10)
                        {
                            Progressor(i, j, Map[i, j + 1]);
                            if (van_szomszed && ProgressCol != Map[i, j] && ProgressCol != "-1")
                            {
                                border = true;
                            }
                        }
                    }
                    if (border)
                    {
                        Map[i, j] = "-1";
                        szamlalo++;
                    }
                    else if (converted)
                    {
                        szamlalo++;
                    }
                    van_szomszed = false;
                    border = false;
                }
            }
        }
        public void Progressor(int X, int Y, string e) //ez valtoztatja a cellaertekeket
        {
            if (int.Parse(Map[X, Y]) > 0 && int.Parse(Map[X, Y]) < 11) 
            {
                Map[X, Y] = Convert.ToString(int.Parse(Map[X, Y]) - 1);
                ProgressCol = "";
            }
            if (Map[X, Y] == "0")
            {
                Map[X, Y] = e;
                converted = true;
                ProgressCol = Map[X, Y];
            }
            else
            {
                converted = false;
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

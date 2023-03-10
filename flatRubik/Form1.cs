using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatRubik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool _DESIGNMODEONLY = false;
        public bool _DEBUGMODEONLY = false;


        public Graphics g;
        public Font font0;
        public Font fontmin;
        public Pen pen0 = new Pen(Color.Black);
        public Pen pen2 = new Pen(Color.Silver, 1);

        public Brush brush0 = new SolidBrush(Color.DimGray);

        public static int posx = 20;
        public static int posy = 20;
        public int xwidth = 100;
        public int yheight = 100;
        public double rad = (180 / Math.PI);
        public int cx = posx + 50;
        public int cy = posy + 50;
        public double sint = Math.Sin((1) / (180 / Math.PI)) * (100 / 2) + 70;
        public double scos = Math.Cos((1) / (180 / Math.PI)) * (100 / 2) + 70;
        public double prevx;
        public double prevy;

        public List<ball> l1 = new List<ball>();
       

        public int currentMousePositionX = 0;
        public int currentMousePositionY = 0;

        public List<Point> mousePressedDown = new List<Point>(); 

        public List<Color> colors = new List<Color>();


        //not real colors just a list
        public void loadColors() { 
            colors.Add(new Color());
            colors[0] = Color.White;
            colors.Add(new Color());
            colors[1] = Color.Black;
            colors.Add(new Color());
            colors[2] = Color.Red;
            colors.Add(new Color());
            colors[3] = Color.Blue;
            colors.Add(new Color());
            colors[4] = Color.Yellow;
            colors.Add(new Color());
            colors[5] = Color.Green;
            colors.Add(new Color());
          

        }



        public void clear()
        {
            g.Clear(BackColor);
        }

        public void drawcircle()
        {

            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                g.DrawLine(pen0, Convert.ToInt16(scos), 100 + Convert.ToInt16(sint), Convert.ToInt16(prevx), 100 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }

        public void drawcircle2()
        {

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (400 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (400 / 2) + cy;
                g.DrawLine(pen0, 200 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 200 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (350 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (350 / 2) + cy;
                g.DrawLine(pen0, 200 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 200 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (300 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (300 / 2) + cy;
                g.DrawLine(pen0, 200 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 200 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }

        public void drawcircle3()
        {

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (400 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (400 / 2) + cy;
                g.DrawLine(pen0, 400 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 400 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (350 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (350 / 2) + cy;
                g.DrawLine(pen0, 400 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 400 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (300 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (300 / 2) + cy;
                g.DrawLine(pen0, 400 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 400 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }


        public void drawcircle4()
        {

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (400 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (400 / 2) + cy;
                g.DrawLine(pen0, 300 + Convert.ToInt16(scos), 400 + Convert.ToInt16(sint), 300 + Convert.ToInt16(prevx), 400 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (350 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (350 / 2) + cy;
                g.DrawLine(pen0, 300 + Convert.ToInt16(scos), 400 + Convert.ToInt16(sint), 300 + Convert.ToInt16(prevx), 400 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (300 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (300 / 2) + cy;
                g.DrawLine(pen0, 300 + Convert.ToInt16(scos), 400 + Convert.ToInt16(sint), 300 + Convert.ToInt16(prevx), 400 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }

        public void drawsin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(sint), i, 270);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcos()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcosplussin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos) + Convert.ToInt16(sint), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcosminussin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos) - Convert.ToInt16(sint), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }

        public void loadPositionsIntoBalls()
        {
            if (_DESIGNMODEONLY == true) { 
                if (listofpositionsXY.Length != 108) { Text = "eroare lista " + listofpositionsXY.Length.ToString(); }
                else if (listofpositionsXY.Length == 108) { Text = " lista OK " + listofpositionsXY.Length.ToString(); }
            }
            int j = 0;
            for (int i = 0; i < 108; i += 2)
            {

                this.l1[j].Left = this.listofpositionsXY[i];
                this.l1[j].Top = this.listofpositionsXY[i + 1];

                if (_DEBUGMODEONLY == true)
                {
                    string s = i.ToString() + ":" + this.l1[j].Left.ToString() + ";" + this.l1[j].Top.ToString();
                     s += "; " +j.ToString() + ";" +this.l1[j].BackColor.ToString() + "\r\n";
                    this.textBox1.Text += s;
                    g.DrawString(s,font0,brush0,new Point(this.l1[j].Left, this.l1[j].Top));
                }
                    j++;
            }
           


        }

        public int[] listofpositionsXY = {
            221,
            462,
            225,
            437,
            230,
            415,
            285,
            344,
            307,
            335,
            329,
            325,
            410,
            325,
            433,
            334,
            457,
            347,
            510,
            414,
            513,
            436,
            519,
            463,
            195,
            456,
            198,
            431,
            207,
            407,
            279,
            320,
            300,
            307,
            323,
            301,
            417,
            299,
            439,
            309,
            460,
            317,
            532,
            407,
            536,
            427,
            543,
            456,
            172,
            444,
            177,
            420,
            185,
            393,
            275,
            294,
            297,
            284,
            319,
            279,
            418,
            275,
            445,
            283,
            469,
            295,
            553,
            391,
            563,
            420,
            567,
            443,
            323,
            407,
            343,
            395,
            366,
            382,
            366,
            161,
            348,
            148,
            326,
            133,
            343,
            426,
            367,
            416,
            387,
            396,
            389,
            147,
            368,
            128,
            345,
            115,
            371,
            446,
            395,
            429,
            413,
            408,
            414,
            132,
            398,
            114,
            371,
            97
        };

        public void addAllBalsToForm() {
            int indexculoare = 0;
            if (_DEBUGMODEONLY) {
                if (this.l1.Count != 54) {
                    Text = "error list not egal cu 54";
                }
            }
            for (int i = 0; i < this.l1.Count; i++)
            {
                this.Controls.Add(l1[i]);
                this.l1[i].Visible = true;
                this.l1[i].setColor(colors[indexculoare]);
                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45) { indexculoare++; }   
            }
            
        }
        public void addBallsInLists()
        {
            for (int i = 0; i < 54; i++)
            {
                this.l1.Add(new ball());

            }
           

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //font0 = Font;
            font0 = new Font("Tahoma", 8);
            fontmin = new Font("Tahoma", 2);
            g = CreateGraphics();


           

            prevx = scos;
            prevy = sint;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            drawcircle2();
            drawcircle3();
            drawcircle4();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentMousePositionX = e.X;
            currentMousePositionY = e.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_DESIGNMODEONLY == true)
            {
                mousePressedDown.Add(new Point(e.X, e.Y));
                this.textBox1.Text += e.X.ToString();
                this.textBox1.Text += "\r\n";
                this.textBox1.Text += e.Y.ToString();
                this.textBox1.Text += "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_DESIGNMODEONLY == false)
            {
                this.textBox1.Visible = false;
                this.button2.Visible = false;
            }
            if(_DEBUGMODEONLY == true)
            {
                this.textBox1.Visible = true;
            }
            loadColors();
            addBallsInLists();
            addAllBalsToForm();
            loadPositionsIntoBalls();
            
        }
    }
}

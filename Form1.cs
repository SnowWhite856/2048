using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048._2
{
    public partial class Form1 : Form
    {
        Graphics grid;
        Dice dice = new Dice();

        Brush bgBrush = new SolidBrush(Color.Black);
        
        Brush trueBrush = new SolidBrush(Color.LightCoral);

        int[,,] DrawCoordinates = { { { 20, 220 }, { 120, 220 }, { 220, 220 }, { 320, 220 }, { 420, 220 } }, { { 20, 320 }, { 120, 320 }, { 220, 320 }, { 320, 320 }, { 420, 320 } }, { { 20, 420 }, { 120, 420 }, { 220, 420 }, { 320, 420 }, { 420, 420 } }, { { 20, 520 }, { 120, 520 }, { 220, 520 }, { 320, 520 }, { 420, 520 } }, { { 20, 620 }, { 120, 620 }, { 220, 620 }, { 320, 620 }, { 420, 620 } } };
        public Form1()
        {
            InitializeComponent();
        }

        void GridCreate(Graphics grid)
        {
            Pen myPen = new Pen(Color.White);
           
            myPen.Width = 8.0F;

            grid.DrawRectangle(myPen, 20, 220, 100, 100);
            grid.DrawRectangle(myPen, 120, 220, 100, 100);
            grid.DrawRectangle(myPen, 220, 220, 100, 100);
            grid.DrawRectangle(myPen, 320, 220, 100, 100);
            grid.DrawRectangle(myPen, 420, 220, 100, 100);

            grid.DrawRectangle(myPen, 20, 320, 100, 100);
            grid.DrawRectangle(myPen, 120, 320, 100, 100);
            grid.DrawRectangle(myPen, 220, 320, 100, 100);
            grid.DrawRectangle(myPen, 320, 320, 100, 100);
            grid.DrawRectangle(myPen, 420, 320, 100, 100);

            grid.DrawRectangle(myPen, 20, 420, 100, 100);
            grid.DrawRectangle(myPen, 120, 420, 100, 100);
            grid.DrawRectangle(myPen, 220, 420, 100, 100);
            grid.DrawRectangle(myPen, 320, 420, 100, 100);
            grid.DrawRectangle(myPen, 420, 420, 100, 100);

            grid.DrawRectangle(myPen, 20, 520, 100, 100);
            grid.DrawRectangle(myPen, 120, 520, 100, 100);
            grid.DrawRectangle(myPen, 220, 520, 100, 100);
            grid.DrawRectangle(myPen, 320, 520, 100, 100);
            grid.DrawRectangle(myPen, 420, 520, 100, 100);

            grid.DrawRectangle(myPen, 20, 620, 100, 100);
            grid.DrawRectangle(myPen, 120, 620, 100, 100);
            grid.DrawRectangle(myPen, 220, 620, 100, 100);
            grid.DrawRectangle(myPen, 320, 620, 100, 100);
            grid.DrawRectangle(myPen, 420, 620, 100, 100);


            grid.FillRectangle(dice.Check(0, 0), 20 + 3, 220 + 3, 94, 94);
            grid.FillRectangle(dice.Check(1, 0), 120 + 3, 220 + 3, 94, 94);
            grid.FillRectangle(dice.Check(2, 0), 220 + 3, 220 + 3, 94, 94);
            grid.FillRectangle(dice.Check(3, 0), 320 + 3, 220 + 3, 94, 94);
            grid.FillRectangle(dice.Check(4, 0), 420 + 3, 220 + 3, 94, 94);

            grid.FillRectangle(dice.Check(0, 1), 20 + 3, 320 + 3, 94, 94);
            grid.FillRectangle(dice.Check(1, 1), 120 + 3, 320 + 3, 94, 94);
            grid.FillRectangle(dice.Check(2, 1), 220 + 3, 320 + 3, 94, 94);
            grid.FillRectangle(dice.Check(3, 1), 320 + 3, 320 + 3, 94, 94);
            grid.FillRectangle(dice.Check(4, 1), 420 + 3, 320 + 3, 94, 94);

            grid.FillRectangle(dice.Check(0, 2), 20 + 3, 420 + 3, 94, 94);
            grid.FillRectangle(dice.Check(1, 2), 120 + 3, 420 + 3, 94, 94);
            grid.FillRectangle(dice.Check(2, 2), 220 + 3, 420 + 3, 94, 94);
            grid.FillRectangle(dice.Check(3, 2), 320 + 3, 420 + 3, 94, 94);
            grid.FillRectangle(dice.Check(4, 2), 420 + 3, 420 + 3, 94, 94);

            grid.FillRectangle(dice.Check(0, 3), 20 + 3, 520 + 3, 94, 94);
            grid.FillRectangle(dice.Check(1, 3), 120 + 3, 520 + 3, 94, 94);
            grid.FillRectangle(dice.Check(2, 3), 220 + 3, 520 + 3, 94, 94);
            grid.FillRectangle(dice.Check(3, 3), 320 + 3, 520 + 3, 94, 94);
            grid.FillRectangle(dice.Check(4, 3), 420 + 3, 520 + 3, 94, 94);

            grid.FillRectangle(dice.Check(0, 4), 20 + 3, 620 + 3, 94, 94);
            grid.FillRectangle(dice.Check(1, 4), 120 + 3, 620 + 3, 94, 94);
            grid.FillRectangle(dice.Check(2, 4), 220 + 3, 620 + 3, 94, 94);
            grid.FillRectangle(dice.Check(3, 4), 320 + 3, 620 + 3, 94, 94);
            grid.FillRectangle(dice.Check(4, 4), 420 + 3, 620 + 3, 94, 94);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool one = true;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            grid = e.Graphics;
            //dice.RandomBlock();

            if (one)
            {

                dice.cordinatesValue[4, 0] = 2;
            }
            GridCreate(e.Graphics);

            one = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 65) //A
            {
                this.Invalidate();
                dice.setUpXY(1);
            }
            if (e.KeyValue == 68) //D
            {
                this.Invalidate();
                dice.setUpXY(2);
            }
            if (e.KeyValue == 87) //W
            {
                this.Invalidate();
            }
            if (e.KeyValue == 83) //S
            {
                this.Invalidate();
            }
            /*if(e.KeyValue == 82) //R
            {
                this.Invalidate();
            }*/
            if(e.KeyValue == 84) //T
            {
                Random random = new Random();
                int x = random.Next(5);
                int y = random.Next(5);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
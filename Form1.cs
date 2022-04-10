﻿using System;
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
        Dice dice = new Dice();
        bool One = true;
        Graphics grid;
        Brush myBrush = new SolidBrush(Color.LightCoral);
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            grid = e.Graphics;

            GridCreate(grid);
            
            if (One)
            {
                int[] Cordinates = dice.RandomBlock();
                grid.FillRectangle(myBrush, DrawCoordinates[Cordinates[0], Cordinates[1], 0] + 3, DrawCoordinates[Cordinates[0], Cordinates[1], 1] + 3, 94, 94);
            }
            else
            {
                grid.FillRectangle(myBrush, DrawCoordinates[dice.lastx, dice.lasty, 0] + 3, DrawCoordinates[dice.lastx, dice.lasty, 1] + 3, 94, 94);
            }
            One = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 65) //A
            {
                this.Invalidate();
                dice.setUpCooridnates(dice.lastx, 0);
            }
            if (e.KeyValue == 68) //D
            {
                this.Invalidate();
                dice.setUpCooridnates(dice.lastx, 4);
            }
            if (e.KeyValue == 87) //W
            {
                this.Invalidate();
                dice.setUpCooridnates(0, dice.lasty);
            }
            if (e.KeyValue == 83) //S
            {
                this.Invalidate();
                dice.setUpCooridnates(4, dice.lasty);
            }
            if(e.KeyValue == 82) //R
            {
                this.Invalidate();
                One = true;
            }
            if(e.KeyValue == 84) //T
            {
                Random random = new Random();
                int x = random.Next(5);
                int y = random.Next(5);
                grid.FillRectangle(myBrush, DrawCoordinates[x, y, 0] + 3, DrawCoordinates[x, y, 1] + 3, 94, 94);
            }
        }
    }
}
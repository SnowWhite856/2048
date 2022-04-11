using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Dice
{
	public int[,] cordinates = new int[5,5];
	public int lastx, lasty;
	public Graphics draw;
	public Brush myBrush;

	public Dice()
    {
		for(int i = 0; i < 5; i++)
        {
			for(int z = 0; z < 5; z++)
            {
				cordinates[i, z] = 0;
            }
        }
    }

	public void drawNew(int x, int y)
    {
		draw.FillRectangle(myBrush, new Rectangle(x, y, 94, 94));
	}

	public void setUpXY(int x, int y, int value)
    {
		cordinates[lastx, lasty] = 0; 

		lastx = x;
		lasty = y;

		cordinates[x, y] = value;
    }

	public int[] RandomBlock()
    {
		Random random = new Random();
		int x = random.Next(5);
		int y = random.Next(5);

		setUpXY(x, y, 2);

		int[] cord = { x, y };

		return cord;
    }
}

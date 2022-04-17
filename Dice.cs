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
	public int[,] cordinatesValue = new int[5,5];
	public int lastx, lasty;

	public Dice()
    {
		for(int i = 0; i < 5; i++)
        {
			for(int z = 0; z < 5; z++)
            {
				cordinatesValue[i, z] = 0;
            }
        }
    }

	public Brush Check(int x, int y)
    {
		Brush visible = new SolidBrush(Color.LightCoral);

		Brush invisible = new SolidBrush(Color.Black);

		if(cordinatesValue[x, y] != 0)
        {
			return visible;
        }
        else
        {
			return invisible;
        }
    }

	public void setUpXY(int x, int y, int value, bool klawisz)
    {
		if (klawisz)
		{
			lastx = x;
			lasty = y;

			cordinatesValue[x, y] = value;
		}
        else
        {
			lastx = x;
			lasty = y;

			cordinatesValue[x, y] = value;
		}
    }

	public void RandomBlock(bool klawisz)
    {
		Random random = new Random();
		int x = random.Next(5);
		int y = random.Next(5);
		setUpXY(x, y, 2, klawisz);
    }
}

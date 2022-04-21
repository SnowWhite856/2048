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

	public void setUpXY(int way)
    {
		switch(way)
        {
            case 1:
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 4; x > 0; x--)
                    {
                        
                        cordinatesValue[x - 1, y] = cordinatesValue[x, y];
                        cordinatesValue[x, y] = 0;
                        Console.WriteLine(cordinatesValue[x, y]);
                        Console.WriteLine(cordinatesValue[x - 1, y]);
                    }
                }
                break;
            case 2:
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 1; x < 5; x++)
                    {
                        cordinatesValue[x, y] = cordinatesValue[x - 1, y];
                        cordinatesValue[x - 1, y] = 0;
                        Console.WriteLine(cordinatesValue[x, y]);
                        Console.WriteLine(cordinatesValue[x - 1, y]);
                    }
                }
                break;
            case 3:
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 4; y > 0; y--)
                    {
                        cordinatesValue[x, y - 1] = cordinatesValue[x, y];
                        cordinatesValue[x, y] = 0;
                        Console.WriteLine(cordinatesValue[x, y]);
                        Console.WriteLine(cordinatesValue[x - 1, y]);
                    }
                }
                break;
            case 4:
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 1; y < 5; y++)
                    {
                        cordinatesValue[x, y] = cordinatesValue[x, y - 1];
                        cordinatesValue[x, y - 1] = 0;
                        Console.WriteLine(cordinatesValue[x, y]);
                        Console.WriteLine(cordinatesValue[x - 1, y]);
                    }
                }
                break;
        }
    }

	public void RandomBlock()
    {
		Random random = new Random();
		int x = random.Next(5);
		int y = random.Next(5);
		cordinatesValue[x, y] = 2;
    }
}

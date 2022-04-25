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
        for (int i = 0; i < 10; i++)
        {
            switch (way)
            {
                case 1:
                    for (int y = 0; y < 5; y++)
                    {
                        for (int x = 4; x > 0; x--)
                        {
                            if (cordinatesValue[x - 1, y] == cordinatesValue[x, y])
                            {
                                cordinatesValue[x - 1, y] += cordinatesValue[x, y];
                                cordinatesValue[x, y] = 0;
                            }
                            Console.WriteLine("{" + Convert.ToString(x - 1) + ", " + Convert.ToString(y) + "} Value: " + Convert.ToString(cordinatesValue[x - 1, y]));
                            Console.WriteLine("New: " + cordinatesValue[x, y]);
                            Console.WriteLine("Last: " + cordinatesValue[x - 1, y]);
                        }
                    }
                    break;
                case 2:
                    for (int y = 0; y < 5; y++)
                    {
                        for (int x = 1; x < 5; x++)
                        {
                            if (cordinatesValue[x, y] == 0)
                            {
                                cordinatesValue[x, y] = cordinatesValue[x - 1, y];
                                cordinatesValue[x - 1, y] = 0;
                            }
                            Console.WriteLine("New: " + cordinatesValue[x, y]);
                            Console.WriteLine("Last: " + cordinatesValue[x - 1, y]);
                        }
                    }
                    break;
                case 3:
                    for (int x = 0; x < 5; x++)
                    {
                        for (int y = 4; y > 0; y--)
                        {
                            if (cordinatesValue[x, y - 1] == 0)
                            {
                                cordinatesValue[x, y - 1] = cordinatesValue[x, y];
                                cordinatesValue[x, y] = 0;
                            }
                            Console.WriteLine("New: " + cordinatesValue[x, y]);
                            Console.WriteLine("last: " + cordinatesValue[x, y - 1]);
                        }
                    }
                    break;
                case 4:
                    for (int x = 0; x < 5; x++)
                    {
                        for (int y = 1; y < 5; y++)
                        {
                            if (cordinatesValue[x, y] == 0)
                            {
                                cordinatesValue[x, y] = cordinatesValue[x, y - 1];
                                cordinatesValue[x, y - 1] = 0;
                            }
                            Console.WriteLine("New: " + cordinatesValue[x, y]);
                            Console.WriteLine("Last: " + cordinatesValue[x, y - 1]);
                        }
                    }
                    break;
            }
        }
    }

	public void RandomBlock()
    {
		Random random = new Random();
        int x, y;
        do
        {
            x = random.Next(5);
            y = random.Next(5);
        } while (cordinatesValue[x, y] != 0);
		cordinatesValue[x, y] = 2;
    }
}

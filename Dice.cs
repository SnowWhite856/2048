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
    public bool lose = true;

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

    public String ScoreChange()
    {
        int Score = 2;
        for(int y = 0; y < 5; y++)
        {
            for(int x = 0; x < 5; x++)
            {
                if(Score < cordinatesValue[x, y])
                {
                    Score = cordinatesValue[x, y];
                }
            }
        }
        return "Score: " + Convert.ToString(Score);
    }

    public bool LoseCheck()
    {
        int moves = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (cordinatesValue[i, j] == 0)
                {
                    moves++;
                }
            }
        }
        if(moves == 0)
        {
            lose = false;
            return true;
        }
        return false;
    }

	public void setUpXY(int way)
    {
        for (int i = 0; i < 5; i++)
        {
            switch (way)
            {
                case 1:
                    for (int y = 0; y < 5; y++)
                    {
                        for (int x = 4; x > 0; x--)
                        {
                            if (cordinatesValue[x - 1, y] == 0)
                            {
                                cordinatesValue[x - 1, y] = cordinatesValue[x, y];
                                cordinatesValue[x, y] = 0;
                            }
                            else if (cordinatesValue[x - 1, y] == cordinatesValue[x, y])
                            {
                                cordinatesValue[x - 1, y] += cordinatesValue[x, y];
                                cordinatesValue[x, y] = 0;
                            }
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
                            else if(cordinatesValue[x, y] == cordinatesValue[x - 1, y])
                            {
                                cordinatesValue[x, y] += cordinatesValue[x - 1, y];
                                cordinatesValue[x - 1, y] = 0;
                            }
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
                            else if (cordinatesValue[x, y - 1] == cordinatesValue[x, y])
                            {
                                cordinatesValue[x, y - 1] += cordinatesValue[x, y];
                                cordinatesValue[x, y] = 0;
                            }
                        }
                    }
                    break;
                case 4:
                    for (int x = 0; x < 5; x++)
                    {
                        for (int y = 1; y < 5; y++)
                        {
                            if (cordinatesValue[x , y] == 0)
                            {
                                cordinatesValue[x, y] = cordinatesValue[x, y - 1];
                                cordinatesValue[x, y - 1] = 0;
                            }
                            else if (cordinatesValue[x, y] == cordinatesValue[x, y - 1])
                            {
                                cordinatesValue[x, y] += cordinatesValue[x, y - 1];
                                cordinatesValue[x, y - 1] = 0;
                            }
                        }
                    }
                    break;
            }
        }
        ScoreChange();
    }

	public void RandomBlock()
    {
		Random random = new Random();
        int x = 0;
        int y = 0;
        do
        {
            if (LoseCheck())
            {
                break;
            }
            x = random.Next(5);
            y = random.Next(5);
        } while (cordinatesValue[x, y] != 0);
        if (!LoseCheck())
        {
            cordinatesValue[x, y] = 2;
        }
    }
}

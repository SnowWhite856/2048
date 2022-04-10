using System;

public class Dice
{
	public int[,] cordinates = new int[5,5];
	public int lastx, lasty;

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

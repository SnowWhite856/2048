using System;

public class Dice
{
	public int lastx, lasty;

	public void setUpCooridnates(int x, int y)
    {
		lastx = x;
		lasty = y;
    }

	public int[] RandomBlock()
    {
		Random random = new Random();
		int x = random.Next(5);
		int y = random.Next(5);

		setUpCooridnates(x, y);

		int[] cord = { x, y };

		return cord;
    }
}

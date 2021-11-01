
using System;

class PatternX
{
	public void Display(int iNo1, int iNo2)
	{
		if(iNo1 < 0)
		{
			iNo1 = -iNo1;
		}

		if(iNo2 < 0)
		{
			iNo2 = -iNo2;
		}

		for(int i = 1; i <= iNo1; i++)
		{
			for(int j = 1; j <= iNo2; j++)
			{
				Console.Write("*\t");
			}
			Console.WriteLine();
		}
	}
}

class main
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter Count of  Rows and Columns");
		int iValue1 = Convert.ToInt32(Console.ReadLine());
		int iValue2 = Convert.ToInt32(Console.ReadLine());

		PatternX pobj = new PatternX();
		pobj.Display(iValue1,iValue2);
	} 
}
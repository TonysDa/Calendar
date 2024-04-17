using System;

public class Program
{
	public static void Main()
	{
		int den = 0;
		Console.WriteLine("Напиши час");
		int chas = int.Parse(Console.ReadLine());
		Console.WriteLine("Напиши минути");
		int minuti = int.Parse(Console.ReadLine());
		Console.WriteLine("Напиши секунди");
		int sekundi = int.Parse(Console.ReadLine());
		Console.WriteLine("Колко добавяме при часа?");
		int chasа = int.Parse(Console.ReadLine());
		int smqtanechas = chas + chasа;
		Console.WriteLine("Колко добавяме при минутите?");
		int minitite = int.Parse(Console.ReadLine());
		int smqtaneminuti = minuti + minitite;
		Console.WriteLine("Колко добавяме при секундите?");
		int sekundite = int.Parse(Console.ReadLine());
		int smqtanesekundite = sekundi + sekundite;
		
		
		if (smqtanesekundite >= 60)
		{
			smqtaneminuti += 1;
			while (smqtanesekundite >= 60)
			{
				smqtanesekundite -= 60;
			}
		}

		if (smqtaneminuti >= 60)
		{
		    smqtanechas += 1;
			while (smqtaneminuti >= 60)
			{
				smqtaneminuti -= 60;
			}
		}

		if (smqtanechas >= 24)
		{
			while (smqtanechas >= 24)
			{
				smqtanechas -= 24;
				den += 1;
			}
		}

		if (smqtanechas < 10 && smqtaneminuti < 10 && smqtanesekundite < 10)
		{
			Console.WriteLine("0{0}:0{1}:0{2} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else if (smqtanechas < 10 && smqtaneminuti < 10)
		{
			Console.WriteLine("0{0}:0{1}:{2} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else if (smqtanechas < 10 && smqtanesekundite < 10)
		{
			Console.WriteLine("0{0}:{1}:0{2} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else if (smqtaneminuti < 10 && smqtanesekundite < 10)
		{
			Console.WriteLine("{0}:0{1}:0{2} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else if (smqtanechas < 10)
		{
			Console.WriteLine("0{0}:{01}:{02} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else if (smqtaneminuti < 10)
		{
			Console.WriteLine("{0}:0{1}:{02} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else if (smqtanesekundite < 10)
		{
			Console.WriteLine("{0}:{01}:0{2} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}
		else
		{
			Console.WriteLine("{0}:{1}:{2} + {3} days", smqtanechas, smqtaneminuti, smqtanesekundite,den);
		}

		Console.WriteLine(den);
	}
}
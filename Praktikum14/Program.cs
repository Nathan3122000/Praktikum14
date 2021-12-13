using System;

namespace Praktikum14
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Input : ");
			int input = Convert.ToInt32(Console.ReadLine());
			if (input == 1)
			{
				Console.WriteLine(1);
			}
			else
			{
				int repeat = 2;
				while (input % repeat != 0)
				{
					repeat = repeat + 1;
				}

				if (input == repeat)
				{
					int firstprime = 2;
					for (int vertikal = 0; vertikal < input; vertikal++)
					{
						for (int horizontal = 0; horizontal < input; horizontal++)
						{
							Console.WriteLine(firstprime);
							firstprime = firstprime + 1;
							int checkprime = 2;
							while (firstprime % checkprime != 0)
							{
								checkprime = checkprime + 1;
							}
							while (firstprime != checkprime)
							{
								firstprime = firstprime + 1;
								checkprime = 2;
								while (firstprime % checkprime != 0)
                                {
                                    checkprime = checkprime + 1;
                                }
                            }
						}
					}
				}
				else
				{
					int firstnonprime = 1;
					for (int vertikal = 0; vertikal < input; vertikal++)
					{
						for (int horizontal = 0; horizontal < input; horizontal++)
						{
							Console.WriteLine(firstnonprime);
							firstnonprime = firstnonprime + 1;
							int checkprime = 2;
							while (firstnonprime % checkprime != 0)
							{
								checkprime = checkprime + 1;
							}
							while (firstnonprime == checkprime)
							{
								firstnonprime = firstnonprime + 1;
								checkprime = 2;
								while (firstnonprime % firstnonprime != 0)
								{
									checkprime = checkprime + 1;
								}
							}
						}
					}
				}
			}
		}
	}
}

// HomeWork 7
// Задача (1) 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
	// m = 3, n = 4.
	// 0,5 7 -2 -0,2
	// 1 -3,3 8 -9,9
	// 8 7,8 -7,1 9
	
// Задача (2) 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
	// Например, задан массив:
	// 1 4 7 2
	// 5 9 2 3
	// 8 4 2 4
	// 17 -> такого числа в массиве нет
	
// Задача (3) 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
	// Например, задан массив:
	// 1 4 7 2
	// 5 9 2 3
	// 8 4 2 4
	// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
	
	void Task_1()
	{
	    double[,] array = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
	    PrintDoubleArray(array);
	}
	

	void Task_2()
	{
	    int[,] array = new int[Random(), Random()];
	    FillArray(array);
	    PrintIntArray(array);
	    FindElement(array);
	}
	

	void Task_3()
	{
	    int[,] array = new int[Random(), Random()];
	    FillArray(array);
	    PrintIntArray(array);
	    double[] summ = SummMiddleColumn(array);
	    PrintArray(summ);
	}
	

	int ReadInt(string argumrntName)
	{
	    Console.Write($"Input {argumrntName}:");
	

	    int number = 0;
	    while (!int.TryParse(Console.ReadLine(), out number))
	    {
	        Console.WriteLine("It's not a number");
	    }
	    return number;
	}
	

	double[,] CreateTwoDimensionArray(int firstLength, int secondLength)
	{
	    double[,] result = new double[firstLength, secondLength];
	    Random rnd = new Random();
	

	    for (int i = 0; i < result.GetLength(0); i++)
	    {
	        for (int j = 0; j < result.GetLength(1); j++)
	        {
	            result[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
	        }
	    }
	

	    return result;
	}
	

	void PrintDoubleArray(double[,] matrix)
	{
	    for (int i = 0; i < matrix.GetLength(0); i++)
	    {
	        for (int j = 0; j < matrix.GetLength(1); j++)
	        {
	            Console.Write($"{matrix[i, j]}\t");
	        }
	        Console.WriteLine();
	    }
	}
	

	void PrintIntArray(int[,] matrix)
	{
	    for (int i = 0; i < matrix.GetLength(0); i++)
	    {
	        for (int j = 0; j < matrix.GetLength(1); j++)
	        {
	            Console.Write($"\t{matrix[i, j]}");
	        }
	        Console.WriteLine();
	    }
	}
	

	int Random()
	{
	    Random random = new Random();
	    int number = random.Next(2, 8);
	    return number;
	}
	

	void FillArray(int[,] matr)
	{
	    for (int i = 0; i < matr.GetLength(0); i++)
	    {
	        for (int j = 0; j < matr.GetLength(1); j++)
	        {
	            matr[i, j] = new Random().Next(1, 10);//[1; 10)
	        }
	    }
	}
	

	void FindElement(int[,] array)
	{
	    int i = ReadInt("i");
	    int j = ReadInt("j");
	    bool search = false;
	

	    while (!search == true)
	        if (i > array.GetLength(0) - 1 || j > array.GetLength(1) - 1)
	        {
	            Console.WriteLine("такого элемента нет, еще раз");
	            i = ReadInt("i");
	            j = ReadInt("j");
	        }
	        else
	        {
	            Console.WriteLine($"элемент = {array[i, j]}");
	            search = true;
	        }
	}
	

	double[] SummMiddleColumn(int[,] array)
	{
	    double[] sum = new double[array.GetLength(1)];
	

	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            sum[j] += array[i, j];
	        }
	    }
	

	    for (int j = 0; j < array.GetLength(1); j++)
	    {
	        sum[j] = Math.Round(sum[j] / array.GetLength(0), 1);
	    }
	

	    return sum;
	}
	

	void PrintArray(double[] summ)
	{
	    Console.WriteLine("");
	    Console.Write($"Ср.Ар =");
	

	    for (int j = 0; j < summ.Length; j++)
	    {
	        Console.Write($"\t{summ[j]}");
	    }
	    Console.WriteLine();
	}
	

	bool inWork = true;
	

	while (inWork)
	{
	    Console.Write("Выбери задачу ");
	

	    if (int.TryParse(Console.ReadLine(), out int i))
	    {
	        switch (i)
	        {
	            case 1:
	                {
	                    Task_1();
	                    break;
	                }
	

	            case 2:
	                {
	                    Task_2();
	                    break;
	                }
	

	            case 3:
	                {
	                    Task_3();
	                    break;
	                }
	            case -1: inWork = false; break;
	        }
	    }
	}




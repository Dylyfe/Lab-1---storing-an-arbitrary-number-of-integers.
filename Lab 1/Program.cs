﻿using System;

namespace Lab_1
{
    class Program
    {
        // Comment 
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int currentIndex = 0;

            bool repeat = true;

            do
            {
                Console.WriteLine("Please enter a integer: ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    repeat = false;
                }

                else
                {
                    try
                    {
                        int number = int.Parse(line);
                        Console.WriteLine("The integer that you entered was: " + number);
                        numbers[currentIndex] = number;
                        currentIndex++;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That was not a integer!");
                        Console.WriteLine();
                    }
                }

                if (currentIndex == numbers.Length)
                {
                    int expandNumberOfCells = currentIndex + 10;
                    int[] expandedNumbers = new int[expandNumberOfCells];

                    for (int i = 0; i < currentIndex; i++)
                    {
                        expandedNumbers[i] = numbers[i];
                    }

                    numbers = expandedNumbers;
                }

            } while (repeat);

            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int a = 0;

            //DONE

            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0



            // Create a do-while loop
            do
            {
                a++;
                numbers.Add(a);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            while (a < 100);

            // While your variable is less than 100


            // Create a while loop
            // While your variable is less than 200
            while (a < 200)
            {
                a++;
                numbers.Add(a);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            Console.WriteLine();

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
            }

            for (int b = 199; b <= numbers.Count && b >= 0; b--)
            {
                Console.WriteLine(numbers[b]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i =0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i =0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i =0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

        }
    }
}

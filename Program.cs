using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(countingFibonachiElement(20)); // here type interesting number

            int countingFibonachiElement(int x)
            {
                var fibonacciNumbers = new List<int> { 1, 1 };

                while (fibonacciNumbers.Count < x)
                {
                    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                    fibonacciNumbers.Add(previous + previous2);
                }
                return fibonacciNumbers[--x];
            }
        }
    }
}



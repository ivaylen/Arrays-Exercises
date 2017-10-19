﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotate = int.Parse(Console.ReadLine());

            int[] sum = new int[input.Length];

            for (int i = 0; i < rotate; i++)
            {
                RotateArray(input);
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + input[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        private static void RotateArray(int[] input)
        {
            var lastNumber = input.Last();
            for (int i = input.Length-1; i > 0; i--)
            {
                input[i] = input[i - 1];            
            }
            input[0] = lastNumber;
        }
    }
}

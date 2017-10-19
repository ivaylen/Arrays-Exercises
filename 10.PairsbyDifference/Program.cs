using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsbyDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var differences = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = number[i];
                for (int j = 0; j < number.Length; j++)
                {
                    int secondNumber = number[j];
                    if (currentNumber - secondNumber == differences)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

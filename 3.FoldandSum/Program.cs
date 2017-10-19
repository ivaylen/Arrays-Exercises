using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int k = numbers.Length / 4;
            int[] leftArray = numbers.Take(k).ToArray();
            int[] middleArray = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArray = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] result = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                result[i] = middleArray[i] + leftArray[i];
                result[i + k] = middleArray[i + k] + rightArray[i];
            }
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMMINGFUNDAMENTALS2017_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var firstInput = Console.ReadLine().Split(' ');
            var secondInput = Console.ReadLine().Split(' ');

            var lenght = Math.Min(firstInput.Length, secondInput.Length);

            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < lenght; i++)
            {
                if(firstInput[i] == secondInput[i])
                {
                    leftCount++;
                }
                if(firstInput[firstInput.Length - i - 1] == secondInput[secondInput.Length - i - 1])
                {
                    rightCount++;
                }
            }
            Console.WriteLine(Math.Max(leftCount, rightCount));
            */
            string[] firstArr = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = FindMaxCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);
            secondArr = secondArr.Reverse().ToArray();
            int rightCount = FindMaxCommonItems(firstArr, secondArr);


            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }
        private static int FindMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}

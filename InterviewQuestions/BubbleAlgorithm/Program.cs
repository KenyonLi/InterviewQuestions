using System;

namespace BubbleAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡算法  int[] arrary = new int[] { 1, 2, 43, 15, 8, 25, 14, 6, 23, 777, 5, 3, 33, 90 };");

            int[] arrary = new int[] { 1, 2, 43, 15, 8, 25, 14, 6, 23, 777, 5, 3, 33, 90 };

            for (int i = 0; i < arrary.Length - 1; i++)
            {
                for (int j = i + 1; j < arrary.Length; j++)
                {
                    if (arrary[i] > arrary[j])
                    {
                        int temp = arrary[j];
                        arrary[j] = arrary[i];
                        arrary[i] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(",", arrary));
            Console.ReadKey();
        }
    }
}

using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.3, 3.6, 4.8, 5.10, 6.369 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Program.ToPrint(intArray);
            Program.ToPrint(doubleArray);
            Program.ToPrint(charArray);
        }

        public static void ToPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("**************");
        }

        public static void ToPrint(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***********");
        }

        public static void ToPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***********");
        }
    }
}

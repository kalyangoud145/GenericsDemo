using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.3, 3.6, 4.8, 5.10, 6.369 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            new GenericClass.PrintArray<int>(intArray).ToPrint();
            new GenericClass.PrintArray<double>(doubleArray).ToPrint();
            new GenericClass.PrintArray<char>(charArray).ToPrint();
        }
        
    }
}

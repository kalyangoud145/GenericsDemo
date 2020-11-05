using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class GenericClass
    {
        //Generic class
        public class PrintArray<T>
        {
            private T[] inputArray;

            public PrintArray(T[] inputArray)
            {
                this.inputArray = inputArray;
            }
            public void ToPrint()
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("**************");
            }
        }
    }
}

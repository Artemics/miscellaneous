using System;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var value = String.Format("{0,10:C}", 126347.89m);         
            Console.WriteLine(value);
        }
    }
}

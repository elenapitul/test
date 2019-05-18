using System;

namespace ReadStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string.");
            string readedLine = Console.ReadLine();

            Console.WriteLine("Please enter a second string.");
            string readedLine2 = Console.ReadLine();

            //Console.WriteLine(readedLine.Length / 2);
            //Console.WriteLine("Hello World!");

            if (readedLine == readedLine2)
            {
                Console.WriteLine("OK");
            }

            //Compare
            // - 1 la stanga dpdv lexiografic
            // 1 la dreapta dpdv lexiografic

            Console.WriteLine(string.Compare(readedLine, readedLine2,true));

            if (readedLine.Equals(readedLine2))
            {
                Console.WriteLine("Equals");
            }
        }
    }
}

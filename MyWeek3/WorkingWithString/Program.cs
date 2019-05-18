using System;
using System.Diagnostics;
using System.Text;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = " Ana are mere! ";
            Console.WriteLine(myString.Length);
            Console.WriteLine($"index of a: {myString.IndexOf('a')}");
            Console.WriteLine($"last index of e: {myString.LastIndexOf('e')}");

            string mere = myString.Substring(9, 4);
            Console.WriteLine(mere);

            string mere2 = myString.Substring(myString.IndexOf('m'), 4);
            Console.WriteLine(mere2);

            string cleanedString = myString.Trim();
            Console.WriteLine(cleanedString);

            string cleanedStringEnd = myString.TrimEnd();
            Console.WriteLine(cleanedStringEnd);

            string replaceString = myString.Replace(" ", ".");
            Console.WriteLine(replaceString);
            string replaceA = myString.Replace("a", "!", true, new System.Globalization.CultureInfo("en-us"));
            Console.WriteLine(replaceA);

            //split
            var splitted = myString.Trim().Split(new char[] { ' ' });

            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }

            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());

            Console.WriteLine(myString.Remove(9, 4));

            //concatenation
            //string concatenated = "";
            //Stopwatch timer = new Stopwatch();
            //timer.Start();

            //for (int i = 0; i < 10000; i++)
            //{
            //    concatenated = concatenated + i.ToString();
            //    //concatenated += i.ToString();
            //}
            //timer.Stop();


            //Console.WriteLine(concatenated);
            //Console.WriteLine(timer.Elapsed);

            //StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            Stopwatch timerForBuilder = new Stopwatch();

            timerForBuilder.Start();

            for (int i = 0; i < 100000; i++)
            {
                stringBuilder.Append(i.ToString());
            }

            timerForBuilder.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stringBuilder);
            
            //Console.WriteLine(timerForBuilder.Elapsed);
        }
    }
}

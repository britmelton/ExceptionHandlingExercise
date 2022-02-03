using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            string str = "";

            foreach (var c in arr)
            {

                try
                {
                    str = c.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }

}

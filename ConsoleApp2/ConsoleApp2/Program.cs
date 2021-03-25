using System;

namespace ConsoleApp2
{
    class Program
    {
        public static int testArg(int arg1,  int arg2, ref int[] mass, out int arg3, in int arg4, params int[] mass2)
        {
           

            foreach(var el in mass2)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine($"The value of arg4 is {arg4}");

            arg3 = 45;
            return arg1 + arg2;
        }
        public static void Main()
        {
            var tuples = (name:1, 4.4, '5', 6);
            Console.WriteLine(tuples);
            int[] mass = new int[] { 1, 3, 4 };

            tuples.name = 3222;
            Console.WriteLine(tuples);


        }

       
    }
}

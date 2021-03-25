//Почему в этом коде не вызывается финализатор класса, хотя явным образом убрана ссылка на экземпляр и вызван сборщик мусора?

using System;

namespace YA_11_GC
{
    class Demo1
    {
        private string s = new String('s', 100);

        public Demo1()
        {
            Console.WriteLine("I am constructed");

        }

        public void DoIt()
        {
            Console.WriteLine("I am doing it!");
        }

        ~Demo1()
        {
            Console.WriteLine("I am destructed");

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Demo1 d1 = new Demo1();
            d1.DoIt();

            d1 = null;
            GC.Collect();

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

    }
}
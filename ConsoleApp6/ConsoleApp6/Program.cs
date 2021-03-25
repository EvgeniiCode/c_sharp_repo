using System;

namespace ConsoleApp6
{

    public class Ages
    {
         public virtual void tt(int age)
        {
            Console.WriteLine("fff");
        }
    }

    class Ager : Ages
    {
        public override void tt (int age)
        {
            Console.WriteLine("sss");
        }
    }

    class Arj
    {
        public const int pii = 33;
    }

    class Program
    {   
        static void Main(string[] args)
        {

            Ager ag1 = new Ager();
            ag1.tt(33);

            

        }
    }
}

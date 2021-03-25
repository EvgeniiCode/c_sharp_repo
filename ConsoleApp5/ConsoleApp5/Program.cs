using System;

namespace ConsoleApp5
{   

    public abstract class Human : Object
    {
        private int _age;
        public string name;

        public int age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public Human(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public abstract int Age { get;}
        public abstract int getCol();
    }


    public class Emp: Human
    {
        private int arg1;
        public Emp(int age, string name) : base(age, name)
        {

        }

        public override int Age {

            get
            {
                return arg1;
            }

        }



        public override int getCol()
        {
            Console.WriteLine("Ovverride method");
            return 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp em1 = new Emp(322, "Tolan");
            Console.WriteLine(em1.age);


        }
    }
}

using System;

namespace ConsoleApp3
{   


    class User
    {
        public int age;
        public string name;
        public User(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public User() : this(12, "Hod")
        {
            Console.WriteLine("Empty constructor");
        }

        public (int, string) getInfo()
        {
            return (this.age, this.name);
        }

        public void getHelp(int param, ref int[] arg1, out int arg2)
        {
            Console.WriteLine(param);
            arg1 = new int[] { 1, 4, 3 };
            arg2 = 68;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            User userf = new User(12, "Tom");
            Console.WriteLine(userf.getInfo());

            int[] mass = new int[] { 1, 1, 1 };

            userf.getHelp(12, ref mass, out int temp1);

            Console.WriteLine($"it is {temp1}");

            foreach(var elem in mass)
            {
                Console.WriteLine(elem);
            }


            User user2 = new User();
            Console.WriteLine(user2.age);
        }
    }
}

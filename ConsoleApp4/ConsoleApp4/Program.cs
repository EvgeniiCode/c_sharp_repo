using System;

namespace ConsoleApp4
{   


    class User
    {
        public  string name { get; set; } = "Tom";
        public int test1;
        public User(string name)
        {
            this.name = name;
        }


        public int tester()
        {
            return 43;
        }
    }


    class Test : User
    {
        public int arc { get; set; } = 32;
        public Test(string name, int temp) : base(name)
        {
            this.arc = temp;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Test tt = new Test("dsds", 444);
            Console.WriteLine(tt.tester());

        }
    }
}

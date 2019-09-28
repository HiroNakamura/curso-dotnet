using System;
using clases;

namespace chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
        }

        static void MockTestA()
        {
            X my_x1 = new X();
            my_x1.Version = "0.0.1";
            var my_x2 = new X("1.0.1");
            Console.WriteLine(my_x1.ToString());
            Console.WriteLine(my_x2.ToString());
        }
    }
}

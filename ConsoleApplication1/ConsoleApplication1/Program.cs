using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int fun_read()
        {
            ConsoleKeyInfo a = Console.ReadKey();
            if (a.KeyChar.ToString() == "q")
            Environment.Exit(0);

            return  int.Parse(a.KeyChar.ToString());
        }


        static int fun_f(int num)
        {
            int a;
            
            if (num == 1)
                return 1;
            //a= fun_f(num - 1);
            num*= fun_f(num - 1);
            //num *= fun_f(num - 1);

            Console.WriteLine("run: " + num);
            return num;

        }


        static void Main(string[] args)
        {
            int num;

        while (true)
            {
                Console.WriteLine("enter:");
                num = fun_read();
                Console.WriteLine();

                num= fun_f(num);
                Console.WriteLine(num);
                Console.WriteLine("____________________________________________");

            }
            
        }
    }
}

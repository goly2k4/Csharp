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
            return  int.Parse(a.KeyChar.ToString());
        }


        static int fun_f(int num)
        {
           
            if (num>0)
                num *= fun_f(num - 1);
           
                return num;
        }


        static void Main(string[] args)
        {

            //Console.WriteLine("abc");
            int num=fun_read();
            //Console.WriteLine(num+5);
            fun_f(num);
            Console.WriteLine(num);

            num = fun_read(); //hold screen
        }
    }
}

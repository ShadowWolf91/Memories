using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Task1()
        {
            bool a;
            byte b;
            sbyte c;
            char d;
            decimal e;
            double f;
            float g;
            int h;
            uint i;
            long j;
            ulong k;
            short l;
            ushort m;

            a = true; b = 1; c = 2; d = 'd'; e = 4; f = 5; g = 6; h = 7; i = 8; j = 9; k = 10; l = 11; m = 12;

            Console.WriteLine("Task 1 \n" + a + "\n" + b + "\n" + c + "\n" + d + "\n" + e + "\n" + f + "\n" + g + "\n" + h + "\n" + i + "\n" + k + "\n" + l + "\n" + m + "\n");
            Console.ReadLine();
        }

        static void Task2()
        {
            int num = 2143;
            long bnum = num;
            byte a = 1;
            float b = a;
            int c = 33;
            float d = c;
            long e = 347;
            double f = e;
            float g = 123;
            double h = g;
            Console.WriteLine("Task 2.1 \n" + num + " " + bnum + "\n" + a + " " + b + "\n" + c + " " + d + "\n" + e + " " + f + "\n" + g + " " + h + "\n");
            Console.ReadLine();

            int num2 = 2143;
            long bnum2;
            bnum2 = (long)num2;
            byte a2 = 1;
            float b2;
            b2 = (float)a2;
            int c2 = 33;
            float d2;
            d2 = (float)c2;
            long e2 = 347;
            double f2;
            f2 = (double)e2;
            float g2 = 123;
            double h2;
            h2 = (double)g2;
            Console.WriteLine("Task 2.2 \n" + num2 + " " + bnum2 + "\n" + a2 + " " + b2 + "\n" + c2 + " " + d2 + "\n" + e2 + " " + f2 + "\n" + g2 + " " + h2 + "\n");
            Console.ReadLine();
        }

        static void Task3()
        {
            int a = 15;
            object b = a;
            int y = (int)b;

            Console.WriteLine("Task 3 \n" + a + "\n" + b + "\n" + y + "\n");
            Console.ReadLine();
        }

        static void Task4()
        {
            var a = 15;
            var b = "asd";
            Console.WriteLine("Task 4 \n" + a + "\n" + b + "\n");
            Console.ReadLine();
        }

        static void Task5()
        {
            int? a = 15;
            Console.WriteLine("Task 5 \n" + a + "\n");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}

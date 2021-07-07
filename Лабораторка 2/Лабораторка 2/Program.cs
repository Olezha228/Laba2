using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторка_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            int n, x, min, max, sum;
            do
            {
                Console.WriteLine("Введите количество чисел в последовательности (число должно быть целым и положительным!): ");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok == false) Console.WriteLine("Ошибка. Введите количество заново.");
            }
            while ((ok == false) || (n<=0));


            do
            {
                Console.WriteLine("Введите число");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out x);
                if (ok == false) Console.WriteLine("Ошибка. Введите число заново, нечисла не принимаются!");
            }
            while (ok == false);

       
            max = x;
            min = x;

            for (int i = 2; i <= n; i++)
            {
                do
                {
                    Console.WriteLine("Введите число");
                    string buf = Console.ReadLine();
                    ok = int.TryParse(buf, out x);
                    if (ok == false) Console.WriteLine("Ошибка. Введите число заново, нечисла не принимаются!");
                }
                while (ok == false);
                if (x >= max) max = x;
                if (x <= min) min = x;
            }
            sum = max+min;
            Console.WriteLine("Максимум = " + max);
            Console.WriteLine("Минимум = " + min);
            Console.WriteLine("Сумма максимума и минимума = " + sum);


           



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, min, numMin, schetchik;
            bool ok;
            do
            {
                Console.WriteLine("Введите целое число: ");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out x);
                if (!ok) Console.WriteLine("Введено ошибочное число. Введите заново.");
            }
            while (ok==false);

            if (x == 0) Console.WriteLine("Пустая последовательность!");
            else
            {
                min = x;
                numMin = 1;
                schetchik = 1;
                while (x != 0)
                {
                    do
                    {
                        Console.WriteLine("Введите целое число: ");
                        string buf = Console.ReadLine();
                        ok = int.TryParse(buf, out x);
                        if(!ok) Console.WriteLine("Введено ошибочное число. Введите заново.");
                    }
                    while (!ok);
                    if (x == 0) break;
                    schetchik += 1;
                    if (x < min)
                    {
                        min = x;
                        numMin = schetchik;
                    }
                    
                }

                Console.WriteLine("Номер минимального числа: " + numMin);
            }
        }
    }
}

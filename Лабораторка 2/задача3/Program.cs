using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            bool ok;
            do
            {
                Console.WriteLine("Введите число: ");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out k);
                if ((ok == false) || (k<1)) Console.WriteLine("Неверный ввод!");
            }
            while ((ok == false) || (k < 1));

            while (k % 3 == 0)
                k = k / 3;
            if (k == 1) Console.WriteLine("Данное число является степенью 3-ки");
            else Console.WriteLine("Данное число не является степенью 3-ки");

        }
    }
}

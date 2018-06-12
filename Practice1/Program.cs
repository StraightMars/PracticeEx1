using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов N: ");
            bool ok;
            int n;
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Ошибка ввода. Введите натуральное число.");
                if (n <= 0)
                {
                    ok = false;
                    Console.WriteLine("Ошибка ввода. Введите натуральное число");
                }
            } while (!ok);
            int[] arr = new int[n];
            Console.WriteLine("Вводите элементы массива через Enter:");
            ok = false;
            int el;
            for (int i = 0; i < n; i++)
            {
                do
                {
                    ok = Int32.TryParse(Console.ReadLine(), out el);
                    if (!ok)
                        Console.WriteLine("Ошибка ввода. Введите целое число.");
                } while (!ok);
                arr[i] = el;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[i] = arr[j];
                        arr.Concat()
                    }
                }
            }
        }
    }
}

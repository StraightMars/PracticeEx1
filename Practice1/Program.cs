using System;
using System.IO;
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
            int N;
            N = Int32.Parse(Console.ReadLine());
            long[] input = new long[N];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Int64.Parse(Console.ReadLine());
            }
            Array.Sort(input);
            long value = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (value >= input[i])
                    value += input[i];
                else
                    break;
            }
            Console.WriteLine(value);
        }
    }
}

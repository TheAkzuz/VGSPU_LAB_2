using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Ведите целое число:");
            a = int.Parse(Console.ReadLine());
            string b = a.ToString();
            int s = b.Length;
            if (b[s - 1] == '7')
            {
                Console.WriteLine("Число оканчивается на 7");
            }
            else
            {
                Console.WriteLine("Число не оканчивается на 7");
            }
        }
    }
}

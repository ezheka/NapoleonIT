using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int rev = 0;

            //переворачиваем число
            while (n > 0)
            {
                int dig = n % 10;
                rev = rev * 10 + dig;
                n = n / 10;
            }

            Console.WriteLine("\nПеревёрнутое число = " + rev);
            if (temp == rev) Console.WriteLine("\nЧисло является палиндромом");
            else Console.WriteLine("\nЧисло не является палиндромом");

            Console.ReadKey();
        }
    }
}

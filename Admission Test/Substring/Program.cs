using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substr1 = Console.ReadLine();

            List<int> begin = new List<int>();
            int end = 0;
            int count_open = 0;


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '[') //проверяем на условие верно ли что символ = [
                {
                    count_open += 1;
                    begin.Add(i); // начало
                }
                else if (str[i] == ']')
                {
                    count_open -= 1;

                    if (count_open == 0)
                    {
                        end = i; //конец
                        break;
                    }
                }
            }

            string substr2 = str.Substring(begin[0], (end - begin[0]) + 1);

            Console.WriteLine("\nИндекс начала: " + begin[0].ToString() + "\nИндекс конца: " + end.ToString());
            Console.WriteLine("\nПодстрока для замены: " + substr2);




            Console.WriteLine("\nОтвет:\n" + str.Replace(substr2, substr1));
            Console.ReadKey();
        }
    }
}

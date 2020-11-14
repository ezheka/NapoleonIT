using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            
            // ввод чисел
            int[] nums = new int[size];
            Console.WriteLine("\nВведите числа:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            // вычисляем количество чётных и нечётных чисел, чтобы потом создать массивы нужного размера
            int number_even_numbers = 0;
            int number_odd_numbers = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    number_even_numbers++;
                }
                else
                {
                    number_odd_numbers++;
                }
            }

            Console.WriteLine("\nКоличество чётных чисел = " + number_even_numbers + "\nКолчисетво нечётных чисел = " + number_odd_numbers);

            int[] array_number_even_numbers = new int[number_even_numbers];
            int[] array_number_odd_numbers = new int[number_odd_numbers];

            // заполняем массивы с четными и нечётными числами
            int even = 0, odd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    array_number_even_numbers[even] = nums[i];
                    even++;
                }
                else
                {
                    array_number_odd_numbers[odd] = nums[i];
                    odd++;
                }
            }

            Array.Sort(array_number_even_numbers); // сортировка массива с чётными числами по возврастанию

            Array.Sort(array_number_odd_numbers); // сортировка массива с нечётными числами по во зврастанию
            Array.Reverse(array_number_odd_numbers); //переворот массива с нечётными числами = числа по убыванию

            nums = array_number_even_numbers.Union(array_number_odd_numbers).ToArray(); // объединяем массивы чётных и нечётных чисел

            Console.Write("\nОтсортированный массив: ");
            foreach (var i in nums)
                Console.Write(" {0}", i);


            Console.ReadLine();
        }
    }
}

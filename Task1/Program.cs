using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        /*
Создайте метод, который в качестве аргумента принимает массив целых чисел и 
возвращает коллекцию квадратов всех нечетных чисел массива.Для формирования 
коллекции используйте оператор yield.
        */
        static IEnumerable<int> GetSquares(ICollection<int> array)
        {
            foreach (var value in array)
            {
                if (value % 2 != 0) yield return value * value;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new String('-', 5));

            foreach(var value in GetSquares(array))
            {
                Console.WriteLine(value);
            }            
        }

    }
}

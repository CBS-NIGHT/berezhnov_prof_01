using System;

namespace Task2
{
    class Program
    {
        /*
Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и
количество дней в соответствующем месяце.Реализуйте возможность выбора месяцев, как по
порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не
только один месяц.
        */
        static void Main(string[] args)
        {
            MonthsCollection monthsCollection = new MonthsCollection();

            foreach (Month month in monthsCollection)
            {
                WriteMonth(month);
            }

            Console.WriteLine(new string('-', 10));

            var m = monthsCollection.GetMonthByNumber(2);
            WriteMonth(m);

            Console.WriteLine(new string('-', 10));

            var moths = monthsCollection.GetMonthsByDays(31);
            foreach(var month in moths)
            {
                WriteMonth(month);
            }

            Console.WriteLine(new string('-', 10));

            foreach(var month in monthsCollection.MonthsByDays(30))
            {
                WriteMonth(month);
            }
        }

        static void WriteMonth(Month month)
        {
            Console.WriteLine($"{month.Number}-{month.Name}-{month.Days}");
        }
    }
}

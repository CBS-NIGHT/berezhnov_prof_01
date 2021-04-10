using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class MonthsCollection : ICollection
    {
        readonly Month[] months =
        {
            new Month("Январь",1,31),
            new Month("Февраль",2,28),
            new Month("Март",3,31),
            new Month("Апрель",4,30),
            new Month("Май",5,31),
            new Month("Июнь",6,30),
            new Month("Июль",7,31),
            new Month("Август",8,31),
            new Month("Сентябрь",9,30),
            new Month("Октябрь",10,31),
            new Month("Ноябрь",11,30),
            new Month("Декабрь",12,31),
        };

        public int Count
        {
            get { return months.Length; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }

        public void CopyTo(Array array, int index)
        {
            var arr = array as object[];
            if (arr == null)
                throw new ArgumentException("Expecting array to be object[]");

            for (int i = 0; i < array.Length; i++)
            {
                arr[index++] = months[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return months.GetEnumerator();
        }

        public Month GetMonthByNumber(int number)
        {
            if (number < 1 || number > 12)
                throw new ArgumentException("Неверный номер месяца");

            return months[number - 1];
        }

        public Month[] GetMonthsByDays(int days)
        {
            List<Month> monthsByDays = new List<Month>();
            foreach(var month in MonthsByDays(days))
            {
                monthsByDays.Add(month);
            }

            return monthsByDays.ToArray();
        }

        public IEnumerable<Month> MonthsByDays(int days)
        {
            foreach (var month in months)
            {
                if (month.Days == days)
                    yield return month;
            }
            
            yield break;
        }
    }
}

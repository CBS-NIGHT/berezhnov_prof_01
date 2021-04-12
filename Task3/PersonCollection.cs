using System;
using System.Collections;

namespace Task3
{
    public class PeopleCollection : ICollection
    {
        private Person[] people = new Person[0];

        private int pensionersCount = 0;

        public int Count => people.Length;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public void CopyTo(Array array, int index)
        {
            var arr = array as object[];
            if (arr == null)
                throw new ArgumentException("Expecting array to be object[]");

            for (int i = 0; i < array.Length; i++)
            {
                arr[index++] = people[i];
            }
        }

        public IEnumerator GetEnumerator() => people.GetEnumerator();

        public bool Contains(Person person)
        {
            return IndexOff(person) >= 0;
        }

        public int IndexOff(Person person)
        {
            for (int i = 0; i < Count; i++)
            {
                if (people[i]==person) return i;
            }
            return -1;
        }

        public bool Contains(int number) =>
            number > 0 && number <= Count;

        public void Add(Person person)
        {
            if (Contains(person))
            {
                Console.WriteLine("Гражданин с паспортом {0} в очереди уже присутствует", person.Id);
                return;
            }

            Person[] newPeople = new Person[Count + 1];

            int index = Count;
            if (person.IsPensioner)
                index = pensionersCount++;
            newPeople[index] = person;

            int i = -1;
            foreach (var p in people)
            {
                i++;
                if (pensionersCount>0 && i == index) i++;
                newPeople[i] = p;
            }
            people = newPeople;
        }
    
        public (int, Person) ReturnLast()
        {
            if(Count<=0)
                throw new ArgumentException("Очередь пуста.");

            return (Count, people[Count - 1]);
        }

        public void Remove()
        {
            if (Count <= 0) return;

            Remove(people[0]);
        }

        public void Remove (Person person)
        {
            int index = IndexOff(person);            
            if (index<0) return;
            
            if (person.IsPensioner) pensionersCount--;

            Person[] newPeople = new Person[Count - 1];
            int i = -1;
            foreach (var p in people)
            { 
                if (++i == index) continue;

                if (i < index) newPeople[i] = p;
                else newPeople[i - 1] = p;
            }
            people = newPeople;
        }

        public void Clear()
        {
            Person[] newPeople = new Person[0];
            people = newPeople;
            pensionersCount = 0;
        }
        
        public void PrintPeople()
        {
            int i = 0;
            foreach (var person in people)
            {
                Console.WriteLine($"#{++i}, {person}");
            }
        }
    }
}

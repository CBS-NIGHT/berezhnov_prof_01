using System;

namespace Task3
{
    class Program
    {
        /*
Создайте абстрактный класс Гражданин. Создайте классы Студент, Пенсионер, Рабочий 
унаследованные от Гражданина. Создайте непараметризированную коллекцию со следующим 
функционалом: 
1. Добавление элемента в коллекцию. 
1) Можно добавлять только Гражданина. 
2) При добавлении, элемент добавляется в конец коллекции. Если Пенсионер, – то в 
начало с учетом ранее стоящих Пенсионеров. Возвращается номер в очереди. 
3) При добавлении одного и того же человека (проверка на равенство по номеру 
паспорта, необходимо переопределить метод Equals и/или операторы равенства для 
сравнения объектов по номеру паспорта) элемент не добавляется, выдается 
сообщение. 
2. Удаление 
1) Удаление – с начала коллекции. 
2) Возможно удаление с передачей экземпляра Гражданина. 
3. Метод Contains возвращает true/false при налчичии/отсутствии элемента в коллекции и 
номер в очереди. 
4. Метод ReturnLast возвращsает последнего чеолвека в очереди и его номер в очереди. 
5. Метод Clear очищает коллекцию. 
6. С коллекцией можно работать опертаором foreach. 
         */
        static void Main(string[] args)
        {
            PeopleCollection people = new PeopleCollection();

            Student student1 = new Student { Id = 123456, Name = "Александр" };
            Student student2 = new Student { Id = 123457, Name = "Александр" };
            Student student3 = new Student { Id = 123458, Name = "Александр" };
            Pensioner pensioner1 = new Pensioner { Id = 456789, Name = "Иван" };
            Pensioner pensioner2 = new Pensioner { Id = 456788, Name = "Иван" };
            Pensioner pensioner3 = new Pensioner { Id = 456787, Name = "Иван" };
            Worker worker1 = new Worker { Id = 789456, Name = "Игорь" };
            Worker worker2 = new Worker { Id = 789455, Name = "Игорь" };
            Worker worker3 = new Worker { Id = 789454, Name = "Игорь" };

            people.Add(pensioner2);
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));

            people.Add(student1);
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));

            people.Add(worker1);
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));

            people.Add(pensioner1);
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));

            people.Add(student2);
            people.Add(worker2);
            people.Add(pensioner2);
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));

            people.Remove();
            people.Remove(student2);
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));

            people.Clear();
            people.PrintPeople();
            Console.WriteLine(new string('-', 10));
        }
    }
}

namespace Task3
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsPensioner => this is Pensioner;

        public override string ToString()
        {
            return $"Паспорт:{Id}, Имя:{Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;

            Person person = (Person)obj;
            return Id == person.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}

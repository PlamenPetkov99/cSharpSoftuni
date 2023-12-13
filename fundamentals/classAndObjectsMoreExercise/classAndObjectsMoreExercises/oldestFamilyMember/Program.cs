namespace oldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            family.People = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string personName = input[0];
                int personAge = int.Parse(input[1]);
                Person person = new Person(personName, personAge);
                family.AddMember(person);


            }
            ;
            Person oldestPerson = family.GetOldest(family.People);

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }

    public class Family
    {
        public List<Person> People { get; set; }

        public void AddMember (Person person) 
        {
            People.Add(person);
        }

        public Person GetOldest (List<Person> persons)
        {
            int oldestPersonAge = persons.Max(person => person.Age);
            List<Person> oldestPerson = persons.Where(person => person.Age == oldestPersonAge).ToList();
            Person oldPerson = new Person(oldestPerson[0].Name, oldestPerson[0].Age);
            
            return oldPerson;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }
    }
}

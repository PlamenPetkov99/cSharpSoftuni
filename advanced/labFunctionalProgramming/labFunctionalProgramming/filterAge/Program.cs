using System;
using System.IO.Pipes;
using System.Threading.Channels;
using System.Xml.Linq;

namespace filterAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                Person person = new Person(age, name);
                persons.Add(person);
            }
            string filterWord = Console.ReadLine();
            int filterNumber = int.Parse(Console.ReadLine());


            string condition = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(filterWord, filterNumber);
            Action<Person> printer = CreatePrinter(condition);
            PrintFilteredPeople(persons, filter, printer);
        }

        private static void PrintFilteredPeople(List<Person> persons, Func<Person, bool> filter, Action<Person> printer)
        {
            List<Person> resultList = persons.Where(filter).ToList();
            foreach (var result in resultList)
            {
                printer(result);
            }
        }

        private static Action<Person> CreatePrinter(string condition)
        {
            if (condition == "name")
            {
                return p => Console.WriteLine(p.Name);
            }
            if (condition == "age")
            {

                return p => Console.WriteLine(p.Age);
            }

            return p => Console.WriteLine($"{p.Name} - {p.Age}");
        }

        private static Func<Person, bool> CreateFilter(string word, int number)
        {
            if (word == "older")
            {
                return per => per.Age >= number;
            }

            return per => per.Age < number;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}

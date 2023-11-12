namespace orderByAge
{
    internal class Program
    {
        /*
         Lewis 123456 20
         James 123456 15
         Robert 523444 11
         Jennifer 345244 13
         Mary 52424678 22
         Patricia 567343 54
         End

         */
        static void Main(string[] args)
        {
            string input = default;
            List<Person> persons = new List<Person>();
            bool isFound = false;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split().ToArray();
                Person person = new Person();

                person.Name = inputTokens[0];
                person.ID = inputTokens[1];
                person.Age = int.Parse(inputTokens[2]);

                foreach (Person human in persons)
                {
                    if(person.ID == human.ID)
                    {
                        human.Name = person.Name;
                        human.Age = person.Age;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    isFound = false;
                    continue;
                }
                
                persons.Add(person);
                

            }

            List<Person> orderedList = persons.OrderBy(x => x.Age).ToList();
            

            foreach (Person person in orderedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }

    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        /*
        public static Person checkForOriginal(List<Person> list , string ID)
        {
            
            foreach (Person person in list)
            {
                if(person.ID == ID)
                {
                    return person;
                }
            }

            return null ; 
        }
        */

        
    }
}
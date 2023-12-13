namespace shoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            string[] inputPersonsRaw = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] inputProductsRaw = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string person in inputPersonsRaw)
            {
                string[] inputTokens = person.Split("=").ToArray();
                string name = inputTokens[0];
                double balance = double.Parse(inputTokens[1]);
                Person currentPerson = new Person(name,balance);
                persons.Add(currentPerson);
            }

            foreach (string product in inputProductsRaw)
            {
                string[] inputTokens = product.Split("=").ToArray();
                string name = inputTokens[0];
                double cost = double.Parse(inputTokens[1]);
                Product currentProduct = new Product(name,cost);
                products.Add(currentProduct);
            }
            


            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                //Peter Bread
                string[] inputTokens = input.Split().ToArray();
                string personName = inputTokens[0];
                string productName = inputTokens[1];

                Person personWhoWantToBuy = persons.Find(person => person.Name == personName);
                Product productWhichPersonWant = products.Find(product => product.ProductName == productName);

                if(personWhoWantToBuy.Money >= productWhichPersonWant.Cost)
                {
                    personWhoWantToBuy.Money -= productWhichPersonWant.Cost;
                    personWhoWantToBuy.Products.Add(productWhichPersonWant);
                    Console.WriteLine($"{personWhoWantToBuy.Name} bought {productWhichPersonWant.ProductName}");

                }
                else
                {
                    Console.WriteLine($"{personWhoWantToBuy.Name} can't afford {productWhichPersonWant.ProductName}");
                }

            }

            foreach (Person currentPerson in persons)
            {

                if(currentPerson.Products.Count > 0)
                {

                    Console.Write($"{currentPerson.Name} - ");
                    for (int i = 0; i < currentPerson.Products.Count; i++)
                    {
                        if(i == currentPerson.Products.Count - 1)
                        {
                            Console.Write(currentPerson.Products[i].ProductName);
                        }
                        else
                        {
                            Console.Write(currentPerson.Products[i].ProductName + ", ");
                        }

                    }
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} - Nothing bought");
                }
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }

        public Person(string name,double balance)
        {
            Name = name;
            Money = balance;
            Products = new List<Product>();

        }

    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Cost { get; set; }

        public Product(string name,double cost)
        {
            ProductName = name;
            Cost = cost;
        }

    }
}

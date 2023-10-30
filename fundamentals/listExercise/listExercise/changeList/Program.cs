namespace changeList
{
    internal class Program
    {
        static List<string> DeleteInteger(List<string> list , string element)
        {
            while (list.Contains(element))
            {
                list.Remove(element);
            }


            return list;
        }

        static List<string> InserElement(List<string> list , string element , int position)
        {
            list.Insert(position, element);

            return list;
        }
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            string input = "";
            while ((input = Console.ReadLine())!= "end")
            {
                List<string> commandsAndValues = input.Split().ToList();//[Delete,{element}]
                string command = commandsAndValues[0];

                switch (command)
                {
                    case "Delete":
                        string elementToDelete = commandsAndValues[1];
                        numbers = DeleteInteger(numbers , elementToDelete);
                        break;
                    case "Insert":
                        string elementToAdd = commandsAndValues[1];
                        int position = int.Parse(commandsAndValues[2]);
                        numbers = InserElement(numbers,elementToAdd,position);
                        break;

                }


            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
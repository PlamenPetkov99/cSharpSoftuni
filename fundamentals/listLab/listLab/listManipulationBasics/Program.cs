using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listManipulationBasics
{
    class Program
    {
        private static List<int> Add(List<int> list , int value)
        {
            list.Insert(list.Count, value);
            return list;
        }
        private static List<int> Remove(List<int> list, int value)
        {
            list.Remove(value);
            return list;
        }

        private static List<int> Removeat(List<int> list, int value)
        {
            list.RemoveAt(value);
            return list;
        }
        private static List<int> Insert(List<int> list, int value , int index)
        {
            list.Insert(index, value);
            return list;
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";
            while ((input=Console.ReadLine()) != "end")
            {
                List<string> commandAndValues = input.Split().ToList();
                string command = commandAndValues[0];
                int value1 = int.Parse(commandAndValues[1]);
                switch (command)
                {
                    case "Add":
                        Add(numbers,value1);
                        break;
                    case "Remove":
                        Remove(numbers, value1);
                        break;
                    case "RemoveAt":
                        Removeat(numbers, value1);
                        break;
                    case "Insert":
                        int value2 = int.Parse(commandAndValues[2]);
                        Insert(numbers, value1, value2);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));


        }
    }
}

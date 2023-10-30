using System;

namespace listOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commandAndValues = input.Split().ToList();

                string command = commandAndValues[0];

                switch (command)
                {
                    case "Add":
                        string elementToAdd = commandAndValues[1];
                        numbers = Add(numbers,elementToAdd);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(commandAndValues[1]);
                        if(indexToRemove < 0 || indexToRemove >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            numbers = Remove(numbers,indexToRemove);
                        }
                        break;
                    case "Shift":
                        string direction = commandAndValues[1];
                        int count = int.Parse(commandAndValues[2]);
                        switch (direction)
                        {
                            case "left":
                                numbers = ShiftLeft(numbers,count);

                                break;
                            case "right":

                                numbers = ShiftRight(numbers, count);
                                break;
                        }
                        break;
                    case "Insert":
                        string numberToInsert = commandAndValues[1];
                        int indexInsert = int.Parse(commandAndValues[2]);
                        if (indexInsert < 0 || indexInsert >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            numbers = InsertNumberIndex(numbers,numberToInsert,indexInsert);
                            
                        }

                        break;


                }


            }
                Console.WriteLine(string.Join(" ",numbers));

            static List<string> Add(List<string> list , string element)
            {
                list.Insert(list.Count, element);

                return list;
            }
            static List<string> Remove(List<string> list, int index)
            {
                list.RemoveAt(index);

                return list;
            }
            static List<string> ShiftLeft(List<string> list, int count)
            {
                for (int i = 0; i < count; i++)
                {
                string firstElement = list[0];
                list.RemoveAt(0);
                list.Insert(list.Count, firstElement);
                

                }


                return list;
            }
            static List<string> ShiftRight(List<string> list, int count)
            {
                for (int i = 0; i < count; i++)
                {
                string lastElement = list[list.Count-1];
                list.RemoveAt(list.Count-1);
                list.Insert(0, lastElement);

                }

                return list;

            }
            static List<string> InsertNumberIndex(List<string> list , string numberToInsert , int indexToInsert)
            {
                list.Insert(indexToInsert, numberToInsert);

                return list;
            }

            
        }
    }
}
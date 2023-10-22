using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergingLists
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<string> list1 = Console.ReadLine().Split().ToList();
            List<string> list2 = Console.ReadLine().Split().ToList();
            List<string> result = new List<string>(list1.Count + list2.Count);
            bool flag = true;
            
            for (int i = 0; i < list1.Count + list2.Count; i++)
            {
                if(list1.Count > 0 && list2.Count > 0)
                {

                    if (flag)
                    {
                        result.Add(list1[i]);
                        list1.Remove(list1[i]);
                        flag = false;
                        i = -1;
                    }
                    else
                    {
                        result.Add(list2[i]);
                        list2.Remove(list2[i]);
                        flag = true;
                        i = -1;
                    }
                }
                else
                {
                    if(list1.Count > list2.Count)
                    {
                        result.AddRange(list1);
                    }
                    else
                    {
                        result.AddRange(list2);
                    }
                    break;
                }
            }

            Console.WriteLine(string.Join(" ",result));

            

        }
    }
}

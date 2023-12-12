using System;
using System.Text;
namespace stringExplode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullSentence = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int strenght = 0;
            for (int i = 0; i < fullSentence.Length; i++)
            {
                char currentChar = fullSentence[i];
                
                if(currentChar == '>') // ako tekushtiq character  e > trqbva da go pribavim kym rezultatut i dobavqme silata.
                {
                    sb.Append(fullSentence[i]);
                    strenght += int.Parse(fullSentence[i + 1].ToString());
                }
                else if(strenght == 0) // ako nqmame nikakva sila i dobavqme prosto tekushtiq simvol
                {
                    sb.Append(fullSentence[i]);
                }
                else // kogato imame sila i trqbva da ignorirame tekushtiq simvol
                {
                    strenght--;
                }

            }

            Console.WriteLine(sb);

        }
    }
}

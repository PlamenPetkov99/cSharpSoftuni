using System.Text;

namespace multiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumer = Console.ReadLine();
            string numberToMultiply = Console.ReadLine();
            List<string> result = new List<string>();
            
            for (int i = 0; i < bigNumer.Length; i++)
            {

            
                int currentNumber = (int)char.GetNumericValue(bigNumer[i]);
                int numberToMulti = int.Parse(numberToMultiply);
                int numberToAppend = currentNumber * numberToMulti;

                
                if(numberToAppend > 9)
                {
                    int left = numberToAppend % 10;

                }
                else
                {
                    
                    result.Add(numberToAppend.ToString());
                    
                }
                

            }
            Console.WriteLine(string.Join("",result));

        }
    }
}

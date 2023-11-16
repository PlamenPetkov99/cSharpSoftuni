namespace companyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = default;
            Dictionary<string,List<string>> companyWithEmployees = new Dictionary<string,List<string>>();

            while((input = Console.ReadLine())!= "End")//"{companyName} -> {employeeId}"
            {
                string[] inputTokens = input.Split(" -> ").ToArray();
                string companyName = inputTokens[0];
                string employeeId = inputTokens[1];

                if(!companyWithEmployees.ContainsKey(companyName))
                {
                    companyWithEmployees[companyName] = new List<string>();
                    companyWithEmployees[companyName].Add(employeeId);
                }
                else
                {
                    if (!companyWithEmployees[companyName].Any(x => x == employeeId))
                    {
                        companyWithEmployees[companyName].Add(employeeId);
                    }
                }

            }


            foreach (KeyValuePair<string,List<string>> kvp in companyWithEmployees)
            {
                Console.WriteLine(kvp.Key);
                foreach (string item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }



        }

        
    }
}
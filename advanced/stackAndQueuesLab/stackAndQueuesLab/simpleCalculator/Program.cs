namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] evaluation = Console.ReadLine().Split().ToArray();
            evaluation = evaluation.Reverse().ToArray();
            Stack<string> numbersOperations = new Stack<string>();

            for (int i = 0; i < evaluation.Length; i++)
            {
                numbersOperations.Push(evaluation[i]);
            }

            int result = int.Parse(numbersOperations.Pop());

            int n = numbersOperations.Count/2;
            for (int i = 0; i < n;i++)
            {
                string operation = numbersOperations.Pop();
                int number = int.Parse(numbersOperations.Pop());

                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;

                }

            }

            Console.WriteLine(result);

        }
    }
}

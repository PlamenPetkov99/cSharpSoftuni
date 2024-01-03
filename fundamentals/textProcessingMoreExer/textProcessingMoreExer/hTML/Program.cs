

namespace hTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            printTitle(title);
            printContent(content);
            string comment = string.Empty;
            while((comment = Console.ReadLine()) != "end of comments")
            {
                printComment(comment);

            }

        }

        private static void printComment(string comment)
        {
            Console.WriteLine("<div>");
            Console.Write("   "); Console.WriteLine(comment);
            Console.WriteLine("</div>");
        }

        public static void printContent(string content)
        {
            Console.WriteLine("<article>");
            Console.Write("   "); Console.WriteLine(content);
            Console.WriteLine("</article>");
        }

        public static void printTitle(string title)
        {
            /*
        <h1>
            SoftUni Article
        </h1>   

             */
            Console.WriteLine("<h1>");
            Console.Write("   "); Console.WriteLine(title);
            Console.WriteLine("</h1>");
        }
    }
}

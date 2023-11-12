using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{title}, {content}, {author}"
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article();

            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ").ToArray();
                string command = tokens[0];
                string value = tokens[1];
                if (command == "Edit")
                {
                    article.Edit(value);
                }   
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(value);
                }
                else if (command == "Rename")
                {
                    article.Rename(value);
                }
            }
            
            Console.WriteLine(article);
            //"{title} - {content}: {author}"
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public  void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        public Article()
        {
        }

    }
}
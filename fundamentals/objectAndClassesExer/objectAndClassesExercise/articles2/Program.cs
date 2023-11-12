using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace articles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberArticles = int.Parse(Console.ReadLine());
            List<Article> art = new List<Article>();
            
            for (int i = 0; i < numberArticles; i++)
            {
            
                Article article = new Article();
                string[] input = Console.ReadLine().Split(", ").ToArray();

                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                art.Add(article);
            }

            foreach (Article item in art)
            {
                Console.WriteLine(item);
            }

            

            
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        

    }
}
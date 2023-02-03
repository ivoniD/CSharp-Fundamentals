using System;

namespace P02._Articles
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article();
            article.Title = articleData[0];
            article.Content = articleData[1];
            article.Author = articleData[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string newcmd = cmdArgs[1];

                if (command == "Edit")
                {
                    article.Edit(newcmd);
                }
                if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newcmd);
                }
                if (command == "Rename")
                {
                    article.Rename(newcmd);
                }
            }

            Console.WriteLine(article);
        }
    }
}

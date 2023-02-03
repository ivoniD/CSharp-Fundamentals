using System;
using System.Collections.Generic;

namespace P01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allPhrases = new string[] {
                "Excellent product.",//0
                "Such a great product.",//1
                "I always use that product.",//2
                "Best product of its category.",//3
                "Exceptional product.",//4
                "I can’t live without this product." };//5

            string[] allEvents = new string[] {
                "Now I feel good.",//0
                "I have succeeded with this product.",//1
                "Makes miracles. I am happy of the results!",//2
                "I cannot believe but now I feel awesome.",//3
                "Try it yourself, I am very satisfied.",//4
                "I feel great!"};//5

            string[] authors = new string[] {
                "Diana",//0
                "Petya",//1
                "Stella",//2
                "Elena",//3
                "Katya",//4
                "Iva",//5
                "Annie",//6
                "Eva"};//7

            string[] cities = new string[] {
                "Burgas",//0
                "Sofia",//1
                "Plovdiv",//2
                "Varna",//3
                "Ruse"};//4

            Random phrase = new Random();
            Random event1 = new Random();
            Random author = new Random();
            Random city = new Random();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int phraseIndex = phrase.Next(allPhrases.Length);
                int eventIndex = event1.Next(allEvents.Length);
                int authorIndex = author.Next(authors.Length);
                int cityIndex = city.Next(cities.Length);

                Console.WriteLine($"{allPhrases[phraseIndex]} {allEvents[eventIndex]} {authors[authorIndex]} – {cities[cityIndex]}.");
            }
        }
    }
}

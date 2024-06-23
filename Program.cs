using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSentenceGenerator
{
    internal class Program
    {
        public static string RandomWord(string[] words)
        {
            Random r = new Random();
            int randomIndex = r.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
        static void Main(string[] args)
        {
            string[] names = { "Steve", "Jane", "Anton", "Brad", "Bruce", "Thor", "Banner", "Peter" };
            string[] places = { "New York City", "Sofia", "Vienna", "Tokyo", "Budapest" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "in the park", "at home", "by the pond" };
            string command;
            Console.Write("Hello, click [ Enter ] to see you first random - generated sentence:");
            while ((command = Console.ReadLine()) != "End")
            {
                string randomName = RandomWord(names);
                string randomPlace = RandomWord(places);
                string randomVerbs = RandomWord(verbs);
                string randomNouns = RandomWord(nouns);
                string randomAdverbs = RandomWord(adverbs);
                string randomDetails = RandomWord(details);
                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverbs} {randomVerbs} {randomNouns}";
                string sentence = $"{who} {action}";
                Console.WriteLine(sentence);
                Console.WriteLine();
                Console.Write("Click [ Enter ] to generate a new one, or write 'End' to close the program: ");
            }
        }
    }
}

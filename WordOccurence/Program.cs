using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string path = args[0];

                try
                {
                    var lines = File.ReadAllLines(path);

                    var sentenceCreator = new SentenceCreator();

                    var sentence = sentenceCreator.Create(lines);

                    var wordOccurenceCounter = new WordOccurenceCounter();

                    var result = wordOccurenceCounter.Count(sentence);

                    foreach (string key in result.Keys)
                    {
                        Console.WriteLine(" {0} : {1} ", result[key], key);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
                Console.Read();
            }
            else
            {
                Console.WriteLine("WordOccurence <filename>");
            }
        }      
            
    }
}

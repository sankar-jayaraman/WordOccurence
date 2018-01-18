using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurence
{
    public class WordOccurenceCounter : IWordOccurenceCounter
    {
        
        public Dictionary<string, int> Count(string sentence)
        {
            var result = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            if (sentence == null)
                return result;

            var words = sentence.Split(' ');
            
            foreach(string word in words)
            {
                if(IsWord(word))
                {
                    var wordInUpperCase = word.ToUpper();

                    if (result.ContainsKey(wordInUpperCase))
                        result[wordInUpperCase]++;
                    else
                        result.Add(wordInUpperCase, 1);
                }
            }

            return result;

        }

        private bool IsWord(string s)
        {
            if(s.Length > 0)
                return s.Count(c => char.IsLetter(c)) == s.Length;
            return false;
        }
    }
}

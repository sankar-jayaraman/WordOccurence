using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurence
{
    public class SentenceCreator : ISentenceCreator
    {
        public string Create(string[] lines)
        {
            var sb = new StringBuilder();

            foreach (string line in lines)
            {
                sb.Append(line.Trim());
                sb.Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}

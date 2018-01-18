using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurence
{
    public interface ISentenceCreator
    {
        string Create(string[] lines);
    }
}

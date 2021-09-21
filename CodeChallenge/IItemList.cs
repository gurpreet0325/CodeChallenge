using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public interface IItemList
    {
        Dictionary<int, string> Items { get; }

        void PopulateItems(string filePath);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class ItemList : IItemList
    {
        public Dictionary<int, string> Items { get; private set; }

        public void PopulateItems(string filePath)
        {
            CSVReader reader = new CSVReader(filePath, true);
            Items = reader.CSVCombo;
        }
    }
}

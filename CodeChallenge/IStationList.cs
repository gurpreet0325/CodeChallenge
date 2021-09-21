using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public interface IStationList
    {
        BindingList<Station> Stations { get; }
        void PopulateStations(string filePath);
        void RemoveStation(int rowIndex);
        void Replace(int rowIndex, int columnIndex);

    }
}

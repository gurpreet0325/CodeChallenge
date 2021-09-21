using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class StationList : IStationList
    {
        public BindingList<Station> Stations { get; private set; }

        public void PopulateStations(string filePath)
        {
            CSVReader reader = new CSVReader(filePath);
            Stations = reader.CSVData;
        }

        public void RemoveStation(int rowIndex)
        {
            if (Stations != null)
                Stations.RemoveAt(rowIndex);
        }

        public void Replace(int rowIndex, int columnIndex)
        {
            Station station = Stations.ElementAt(rowIndex);

            switch (columnIndex)
            {
                case 1:
                    station.StationName = ReplaceCharacter.Replace(station.StationName);
                    break;
                case 5:
                    station.Comment = ReplaceCharacter.Replace(station.Comment);
                    break;
                default:
                    break;
            }
        }
    }
}

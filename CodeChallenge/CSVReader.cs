using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChallenge
{
    public class CSVReader
    {
        public BindingList<Station> CSVData { get; }
        public Dictionary<int, string> CSVCombo { get; }

        public CSVReader(string filePath, bool isForCombo = false)
        {
            if (!isForCombo)
                CSVData = GetData(filePath);
            else
                CSVCombo = GetComboItem(filePath);
        }

        private BindingList<Station> GetData(string filePath)
        {
            BindingList<Station> output = new BindingList<Station>();

            try
            {
                if (filePath.Trim() == string.Empty)
                    return output;

                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    if (!parser.EndOfData)
                    {
                        parser.SetDelimiters(",");

                        string[] headers = parser.ReadFields();
                    }

                    while (!parser.EndOfData)
                    {
                        string[] dataRow = parser.ReadFields();
                        if (dataRow.Any(a => !string.IsNullOrWhiteSpace(a)))
                        {
                            output.Add(new Station
                            {
                                StationName = dataRow[0],
                                ScreenID = Convert.ToInt32(dataRow[1]),
                                Date = Convert.ToDateTime(dataRow[2]),
                                DepthToWaterLevel = Convert.ToDecimal(dataRow[3]),
                                Comment = dataRow[4]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            return output;
        }

        private Dictionary<int, string> GetComboItem(string filePath)
        {
            Dictionary<int, string> output = new Dictionary<int, string>();

            try
            {
                if (filePath.Trim() == string.Empty)
                    return output;

                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    if (!parser.EndOfData)
                    {
                        parser.SetDelimiters(",");

                        string[] headers = parser.ReadFields();
                    }

                    while (!parser.EndOfData)
                    {
                        string[] dataRow = parser.ReadFields();
                        if (dataRow.Any(a => !string.IsNullOrWhiteSpace(a)))
                        {
                            output.Add(Convert.ToInt32(dataRow[0]), dataRow[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            return output;
        }
    }
}

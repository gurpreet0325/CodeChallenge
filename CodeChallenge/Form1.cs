using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CodeChallenge
{
    public partial class Form1 : Form
    {
        IStationList stationListService;
        IItemList itemListService;
        public Form1(IStationList iStationListService, IItemList iItemListService)
        {
            InitializeComponent();
            stationListService = iStationListService;
            itemListService = iItemListService;
        }

        private void btnUploadGrid_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.InitialDirectory = "c:\\";
                    dialog.Filter = "CSV files (*.csv)|*.csv";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        stationListService.PopulateStations(dialog.FileName);
                        dgCSVData.DataSource = stationListService.Stations;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void dgCSVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgCSVData.Columns["btnDelete"].Index)
                {
                    stationListService.RemoveStation(e.RowIndex);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCSVData.SelectedCells.Count > 0)
                {
                    stationListService.Replace(dgCSVData.SelectedCells[0].RowIndex, dgCSVData.SelectedCells[0].ColumnIndex);
                    dgCSVData.DataSource = stationListService.Stations;
                    dgCSVData.Refresh();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnUploadCombo_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.InitialDirectory = "c:\\";
                    dialog.Filter = "CSV files (*.csv)|*.csv";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        itemListService.PopulateItems(dialog.FileName);
                        cbItems.DataSource = itemListService.Items.ToList();
                        cbItems.ValueMember = "key";
                        cbItems.DisplayMember = "value";
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnShowValue_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbItems.SelectedItem != null)
                {
                    MessageBox.Show($"The {cbItems.Text} value is {cbItems.SelectedValue}.", "Details");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

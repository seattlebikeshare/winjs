using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;

namespace SeattleBikeShare.Library.DataModel
{
    public class SampleDataSource : IBikeShareDataSource
    {
        public SampleDataSource()
        {
            this.ViewModelData = new BikeShareViewModel();
        }

        public async Task RefreshData()
        {
            Uri dataUri = new Uri("ms-appx:///DataModel/SampleData.json");
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(dataUri);
            
            string fileContents = await FileIO.ReadTextAsync(file);
            BikeShareViewModel viewModel = JsonConvert.DeserializeObject<BikeShareViewModel>(fileContents);

            this.ViewModelData = viewModel;
        }

        private void UpdateViewModel(IEnumerable<BikeStation> bikeStations)
        {
            this.ViewModelData.BikeStations.Clear();

            foreach (BikeStation station in bikeStations)
            {
                this.ViewModelData.BikeStations.Add(station);
            }
        }

        public BikeShareViewModel ViewModelData { get; private set; }
    }
}
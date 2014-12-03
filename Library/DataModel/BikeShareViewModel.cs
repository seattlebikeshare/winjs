using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SeattleBikeShare.Library.Annotations;

namespace SeattleBikeShare.Library.DataModel
{
    /// <summary>
    /// Main view model to feed into the view.
    /// </summary>
    public class BikeShareViewModel : INotifyPropertyChanged
    {
        public BikeShareViewModel()
        {
            this.BikeStations = new ObservableCollection<BikeStation>();
            this.BikeStations.CollectionChanged += (sender, args) => this.OnPropertyChanged("BikeStations");
        }

        public ObservableCollection<BikeStation> BikeStations { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Task Refresh()
        {
            throw new NotImplementedException();
        }
    }
}

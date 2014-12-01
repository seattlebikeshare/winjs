using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeattleBikeShare.WindowsPhone.Annotations;

namespace SeattleBikeShare.WindowsPhone.DataModel
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
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class SampleViewModel2
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }
}

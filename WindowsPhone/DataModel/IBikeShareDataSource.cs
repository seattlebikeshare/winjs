using System.Threading.Tasks;

namespace SeattleBikeShare.WindowsPhone.DataModel
{
    /// <summary>
    /// Data source interface for pulling bike share data into the view model.
    /// </summary>
    public interface IBikeShareDataSource
    {
        /// <summary>
        /// View model data that will be pulled.
        /// </summary>
        BikeShareViewModel ViewModelData { get; }

        /// <summary>
        /// Retrieve bike share data.
        /// </summary>
        Task RefreshData();
    }
}
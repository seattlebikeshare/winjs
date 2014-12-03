using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SeattleBikeShare.Library.DataModel;

namespace SeattleBikeShare.Test
{
    [TestClass]
    public class BikeShareViewModelTests
    {
        private BikeShareViewModel _viewModel;

        [TestInitialize]
        public void TestInitialize()
        {
            this._viewModel = new BikeShareViewModel();
        }

        [TestMethod]
        public void DefaultViewModelIsEmpty()
        {
            // Assert
            this._viewModel.BikeStations
                .Should().NotBeNull()
                .And.BeEmpty();
        }
    }
}

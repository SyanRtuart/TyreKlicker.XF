using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TyreKlicker.XF.Core.Factory;
using TyreKlicker.XF.Core.Models;

namespace TyreKlicker.XF.Core.ViewModels
{
    public class OrderViewModel : MvxNavigationViewModel
    {
        private MvxAsyncCommand _refreshCommand;

        public ICommand RefreshCommand => _refreshCommand = _refreshCommand ?? new MvxAsyncCommand(async () => await DoMyCommand());

        private async Task<Order> DoMyCommand()
        {
            var data = await ApiClientFactory.Instance.GetOrders();
            return null;
        }

        public ObservableCollection<Order> StringItems { get; set; }

        public OrderViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            //RefreshCommand = new MvxAsyncCommand(async () => await StringItems = ApiClientFactory.Instance.GetOrders());

            StringItems = new ObservableCollection<Order>
            {
                new Order{ AcceptedByUserId = Guid.NewGuid(), CreatedByUserId = Guid.NewGuid(), Description = "123", Id = Guid.NewGuid(), Registration = "rasdas"},
                new Order{ AcceptedByUserId = Guid.NewGuid(), CreatedByUserId = Guid.NewGuid(), Description = "123", Id = Guid.NewGuid(), Registration = "rasdas"},
                new Order{ AcceptedByUserId = Guid.NewGuid(), CreatedByUserId = Guid.NewGuid(), Description = "123", Id = Guid.NewGuid(), Registration = "rasdas"},
                new Order{ AcceptedByUserId = Guid.NewGuid(), CreatedByUserId = Guid.NewGuid(), Description = "123", Id = Guid.NewGuid(), Registration = "rasdas"},
            };
        }
    }
}
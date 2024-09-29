using Prism.Navigation;
using SuperShop.Mobile.Helpers;

namespace SuperShop.Mobile.ViewModels
{
    public class ShowHistoryPageViewModel : ViewModelBase
    {
        public ShowHistoryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ShowPurchaseHistory;
        }
    }
}

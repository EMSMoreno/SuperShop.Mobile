using Prism.Navigation;
using SuperShop.Mobile.Helpers;

namespace SuperShop.Mobile.ViewModels
{
    public class ShowCartPageViewModel : ViewModelBase
    {
        public ShowCarPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ShowShoppingCar;
        }
    }
}

﻿using Prism.Commands;
using Prism.Navigation;
using SuperShop.Mobile.Models;
using SuperShop.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperShop.Mobile.ItemViewModel
{
    public class MenuItemViewModel : Menu
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectMenuCommand;

        public MenuItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectMenuCommand =>
            _selectMenuCommand ??
            (_selectMenuCommand = new DelegateCommand(SelectMenuAsync));



        private async void SelectMenuAsync()
        {
            await _navigationService.NavigateAsync
                ($"/{nameof(SuperShopMasterDetailPage)}/NavigationPage/{PageName}");
        }
    }
}

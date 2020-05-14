using System;
using System.Collections.Generic;
using Menu = CafeExpresso.Models.Menu;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using CafeExpresso.Models;

namespace CafeExpresso.Pages
{
    public partial class SubMenuPage : ContentPage
    {

        public ObservableCollection<SubMenu> SubMenus;

        public SubMenuPage(Menu subMenu)
        {
            InitializeComponent();
            SubMenus = new ObservableCollection<SubMenu>();
            foreach (var item in subMenu.SubMenus)
            {
                SubMenus.Add(item);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SubMenuListView.ItemsSource = SubMenus;
        }
    }
}

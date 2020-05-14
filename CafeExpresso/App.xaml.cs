using System;
using CafeExpresso.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CafeExpresso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Set Main Page to a Navigation Page
            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

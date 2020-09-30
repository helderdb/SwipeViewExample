using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SwipeView.Views;

namespace SwipeView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SwipeViewExample();
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

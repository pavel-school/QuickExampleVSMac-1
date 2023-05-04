using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App123
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Adding a comment to chage the code
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

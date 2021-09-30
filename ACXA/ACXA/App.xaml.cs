#region Using Directives
using System;
using ACXA.Services;
using ACXA.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#endregion

namespace ACXA
{
    public partial class App : Application
    {

        public App ( ) {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ( ) {
        }

        protected override void OnSleep ( ) {
        }

        protected override void OnResume ( ) {
        }
    }
}

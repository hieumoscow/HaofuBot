using System;

using Xamarin.Forms;
using Airbot.Views;

namespace Airbot
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}

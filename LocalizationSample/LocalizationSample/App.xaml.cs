using LocalizationSample.Resources;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LocalizationSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var culture = CrossMultilingual.Current.DeviceCultureInfo;
            AppResources.Culture = culture;

            MainPage = new NavigationPage(new LocalizationSample.MainPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts

        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

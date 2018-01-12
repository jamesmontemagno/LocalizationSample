using LocalizationSample.Model;
using LocalizationSample.Resources;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalizationSample
{
	public partial class MainPage : ContentPage
	{
        public ObservableCollection<Language> Languages { get; }
		public MainPage()
		{
			InitializeComponent();
            Languages = new ObservableCollection<Language>()
            {
                new Language { DisplayName =  "中文 - Chinese (simplified)", ShortName = "zh-Hans" },
                new Language { DisplayName =  "Chinese(Traditional)", ShortName = "zh-Hant" },
                new Language { DisplayName =  "English", ShortName = "en" },
                new Language { DisplayName =  "Français - French", ShortName = "fr" },
                new Language { DisplayName =  "Deutsche - German", ShortName = "de" },
                new Language { DisplayName =  "日本語 - Japanese", ShortName = "ja" },
                new Language { DisplayName =  "한국어 - Korean", ShortName = "ko" },
                new Language { DisplayName =  "Română - Romanian", ShortName = "ro" },
                new Language { DisplayName =  "Русский - Russian", ShortName = "ru" }
            };

            BindingContext = this;

            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;
        }

        private void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = Languages[PickerLanguages.SelectedIndex];

            try
            {
                var culture = new CultureInfo(language.ShortName);
                AppResources.Culture = culture;
                CrossMultilingual.Current.CurrentCultureInfo = culture;
            }
            catch (Exception)
            {
            }

            LabelTranslate.Text = AppResources.HelloWorld;
        }
    }
}

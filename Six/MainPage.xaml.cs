using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Six
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

       async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Turn On Flashlight  
                await Flashlight.TurnOnAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await ShowAlert(fnsEx.Message);
            }
            catch (PermissionException pEx)
            {
                await ShowAlert(pEx.Message);
            }
            catch (Exception ex)
            {
                await ShowAlert(ex.Message);
            }

        }

        public async Task ShowAlert(string message)
        {
            await DisplayAlert("Faild", message, "Ok");
        }
    }
}

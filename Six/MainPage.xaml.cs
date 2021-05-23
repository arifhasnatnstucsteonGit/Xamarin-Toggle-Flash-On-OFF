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

        bool isFlashOn = false;

        public MainPage()
        {
            InitializeComponent();

        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (isFlashOn)
            {
                isFlashOn = !isFlashOn;
                turnOFFflash();
            }
            else {
                isFlashOn = !isFlashOn;
                turnONflash();
            }
            

        }

        async public void turnONflash() {
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

        async public void turnOFFflash() {
            try
            {
                // Turn Off Flashlight  
                await Flashlight.TurnOffAsync();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1.CThree
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class coc3 : ContentPage
	{
		public coc3 ()
		{
			InitializeComponent ();
		}

        private async void Coc3_Tap1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new coc3_p1());
        }

        private async void Coc3_Tap2(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new coc3_p2());
            await DisplayAlert("Warning", "This page is locked, finish the current page first", "OK");
        }

        private async void Coc3_Tap3(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new coc3_p3());
            await DisplayAlert("Warning", "This page is locked, finish the current page first", "OK");
        }
    }
}
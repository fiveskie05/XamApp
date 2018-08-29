using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1.CTwo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class coc2 : ContentPage
	{
		public coc2 ()
		{
			InitializeComponent ();
		}

        private async void Coc2_Tap1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new coc2_p1());
        }

        private async void Coc2_Tap2(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new coc2_p2());
            await DisplayAlert("Warning", "This page is locked, finish the current page first", "OK");
        }

        private async void Coc2_Tap3(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new coc2_p3());
            await DisplayAlert("Warning", "This page is locked, finish the current page first", "OK");
        }
    }
}
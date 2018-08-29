using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1.COne
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class coc1_p2 : ContentPage
	{
		public coc1_p2 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new coc1_p3());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            
        }
    }
}
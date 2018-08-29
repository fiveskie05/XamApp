using P1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1.Intro
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class intro1 : ContentPage
	{
		public intro1 ()
		{
			InitializeComponent ();
            BindingContext = new Locker();
		}

        private async void TapGame(object sender, EventArgs e)
        {
 
            await Navigation.PushAsync(new Detail());
            
        }
    }
}
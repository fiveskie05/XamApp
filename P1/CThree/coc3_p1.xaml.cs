﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1.CThree
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class coc3_p1 : ContentPage
	{
		public coc3_p1 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new coc3_p2());
        }
    }
}
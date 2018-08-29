using P1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
        public Detail()
        {
            InitializeComponent();
            BindingContext = new Locker();
        }

        protected override bool OnBackButtonPressed()
        {
            DependencyService.Get<Toast>().Show("Thank you");
                return base.OnBackButtonPressed();
            
        }

        private async void Intro_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Intro.intro1());
        }

        private async void C1_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new COne.coc1());
        }

        private async void C2_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CTwo.coc2());
        }

        private async void C3_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CThree.coc3());
        }

        private async void Lock_Tap(object sender, EventArgs e)
        {
            await DisplayAlert("Warning", "This page is locked, finish the current page first", "OK");
        }
    }
}
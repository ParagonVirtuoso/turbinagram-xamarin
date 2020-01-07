using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Turbinagram.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Loading : ContentPage
	{
		public Loading ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAlert("Jarradis","GGWP","VAMOS ");
            //Thread.Sleep(5000);
            App.Current.MainPage = new Turbinagram.Layouts.TelaHome();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Turbinagram
{
    public partial class MainPage : ContentPage
    {
        private const string FirebaseURL = "https://turbinagram-1c300.firebaseio.com/";       

        public MainPage()
        {
            InitializeComponent();
            
            

        }

        private void LogButtonClick(object sender, EventArgs args)
        {
            App.Current.MainPage = new Turbinagram.Layouts.TelaLogin();
        }

        private void ConhecerButtonClick(object sender, EventArgs args)
        {
            Device.OpenUri(new System.Uri("https://denysfernandes.tech"));
        }
    }
}

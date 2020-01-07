using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Turbinagram.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaLogin : ContentPage
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void EntrarButtonClick(object sender, EventArgs args)
        {
            //Realizar tratamentos de login aqui !
            App.Current.MainPage = new Turbinagram.Layouts.Loading();
        }

        private void EsqcSenhaClick(object sender, EventArgs args)
        {
            Device.OpenUri(new System.Uri("https://www.instagram.com/accounts/password/reset/"));
        }

        private void InfoPlanoClick(object sender, EventArgs args)
        {
            Device.OpenUri(new System.Uri("https://denysfernandes.tech"));
        }
    }
}
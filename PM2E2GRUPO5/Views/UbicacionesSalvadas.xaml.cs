using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E2GRUPO5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicacionesSalvadas : ContentPage
    {
        public UbicacionesSalvadas()
        {
            InitializeComponent();
        }

        private async void nuevaubicacion_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevaUbicacion());
        }
    }
}
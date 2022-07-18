using Plugin.AudioRecorder;
using PM2E2GRUPO5.Controllers;
using PM2E2GRUPO5.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        ItemTappedEventArgs elemento = null;

        public UbicacionesSalvadas()
        {
            InitializeComponent();
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListaSitios.ItemsSource = await SitioController.GetAllSite();
            elemento = null;
        }

        private async void nuevaubicacion_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevaUbicacion());
        }

        private void ListaSitios_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            elemento = e;
            btnactualizar.IsEnabled = true;
            btnescucharaudio.IsEnabled = true;
            btnvermapa.IsEnabled = true;
        }

        private void btnactualizar_Clicked(object sender, EventArgs e)
        {
            var secondPage = new ModificarUbicacion();
            var sitio = (Sitio)elemento.Item;
            secondPage.BindingContext = new { sitio };
            Navigation.PushAsync(secondPage);
        }

        private void btnvermapa_Clicked(object sender, EventArgs e)
        {

        }

        private void btnescucharaudio_Clicked(object sender, EventArgs e)
        {
            var sitio = (Sitio)elemento.Item;

            // Crea un archivo temporal y obtiene 
            // su ruta:
            string archivoTemp = Path.GetTempFileName();
            File.WriteAllBytes(archivoTemp, sitio.AudioFile);

            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play(archivoTemp);

            File.Delete(archivoTemp);
        }
    }
}
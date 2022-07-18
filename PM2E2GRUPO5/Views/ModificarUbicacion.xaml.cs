using PM2E2GRUPO5.Models;
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
    public partial class ModificarUbicacion : ContentPage
    {
        public ModificarUbicacion(Sitio sitio)
        {
            InitializeComponent();
            //var strokesSignature = sitio.FirmaDigital.Strokes;
            //PadView.Strokes = strokesSignature;
        }

        private void cleandescripcion_Clicked(object sender, EventArgs e)
        {
            descripcion.Text = null;
        }

        private void btnactualizar_Clicked(object sender, EventArgs e)
        {

        }

        private void btneliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
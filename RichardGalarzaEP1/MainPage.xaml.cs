using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RichardGalarzaEP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage( String Usuario )
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

      

        private async void btnResumen_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen());

        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        
        {
            string usuario = lblUsuario.Text;
            await Navigation.PushAsync(new Registro(usuario));

        }
    }
}

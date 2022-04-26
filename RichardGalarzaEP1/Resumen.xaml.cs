using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RichardGalarzaEP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        private string usuario;

        public Resumen(string usuario)
        {
            this.usuario = usuario;
        }

        public Resumen(string Usuario, string nombre, string montof)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            lblNombre.Text = nombre;
            lblMonto.Text = montof;
            
            
            
           
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage(usuario));
        }
    }
}
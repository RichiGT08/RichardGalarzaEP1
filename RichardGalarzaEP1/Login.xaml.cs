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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrirHome_Clicked(object sender, EventArgs e)
        {
            {
                string usuario = txtUsuario.Text;
                string pass = txtPass.Text;

                if ((usuario == "estudiante2021") && (pass == "uisrael2021"))
                {
                    await Navigation.PushAsync(new MainPage(usuario));
               
                }
                else
                {
                    DisplayAlert("CREDENCIALES INCORRECTAS", usuario, "CERRAR"); 
                }
             }
    }
}
}

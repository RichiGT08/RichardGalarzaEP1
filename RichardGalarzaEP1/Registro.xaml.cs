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
    public partial class Registro : ContentPage
    {
        public Registro(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {

        }

        private void btnguardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
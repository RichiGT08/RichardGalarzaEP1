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
        public Registro(String Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;


        }

        private async void btncalcular_Clicked(object sender, EventArgs e)
        {
            var montoI = double.Parse(txtMontoI.Text);
            var mensualI= 1800 - montoI;
            var mensualC = mensualI / 3;
            var mensualF = mensualC * 1.05;
          
            

            string MensajeCal = "Su cuota mensual es de: " + mensualF + " por 3 meses";

            DisplayAlert("Calculo de cuota:", MensajeCal, "Aceptar .");


        }


        public async void btnguardar_Clicked(object sender, EventArgs e)

        {
            string usuario = lblUsuario.Text;
            string nombre = txtNombre.Text;
            string montof = txttotal.Text;
            
           
            string MensajeFin = "Enviar datos de:" + nombre + " a la Ventana Resumen .";

            bool result = await DisplayAlert("ELEMENTOS GUARDADOS...", MensajeFin, "Continuar","Cancelar");
            if (result==true)
            {
                
                await Navigation.PushAsync(new Resumen(usuario,nombre,montof));
            }
           
        }
    }
}
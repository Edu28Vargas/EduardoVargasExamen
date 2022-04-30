using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EduardoVargasExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
        {
        public Resumen(string user, string nombre, string matricula, string cuotas, string total1)
            {
                InitializeComponent();
                lbluser.Text = "Usuario Activo: " + user;
                lblNombre.Text = nombre;
                lblValMat.Text = matricula;
                lblCuotas.Text = cuotas;
                lblTotal.Text = total1;

            }

            private async void btnSalir_Clicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
     }

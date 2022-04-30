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
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();

            lbluser.Text = "Usuario Activo: " + user;
        }

        private void btnCuota_Clicked(object sender, EventArgs e)
        {
            float valorTotal = 3000;
            float interes;
            float saldo;
            

            try
            {
                double matricula = Convert.ToDouble(txtMonto.Text);
                double cuota = Convert.ToDouble(txtCuota.Text);

                saldo = (float)(valorTotal - matricula);

                interes = (float)(saldo * 0.05);

                cuota = (saldo / 5) + interes;
                txtCuota.Text = cuota.ToString();




            }
            catch (Exception )
            {
            }
        }

        private async void btnResumen_Clicked(object sender, EventArgs e)
        {

            if ((txtNombre == null) && (txtMonto == null))
            {
                await DisplayAlert("Alerta", "LLene los Campos Solicitados", "cerrar");
            }
            else
            {

                string user1 = lbluser.Text;
                string nombre = txtNombre.Text;
                string matricula = txtMonto.Text;
                string cuotas = txtCuota.Text;
                decimal totalCuotas = Convert.ToDecimal(cuotas);
                decimal total = Convert.ToDecimal(matricula) + Convert.ToDecimal(cuotas);
                string total1 = Convert.ToString(total);

                await Navigation.PushAsync(new Resumen(user1, nombre, matricula, cuotas, total1));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntroductiontoXamarin.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Seteamos nuestras variables
        double N1, N2, Resultado;

        public void btnHome_Clicked(System.Object sender,System.EventArgs e)
        {
            DisplayAlert("Titulo de la alerta","Descripcion de la alerta","Ok");
        }

        public void btnCalcular_Clicked(Object sender, EventArgs e)
        {
            this.calcular();
        }

        private void calcular()
        {
            if (!string.IsNullOrEmpty(txtNumeroUno.Text))
            {
                if (!string.IsNullOrEmpty(txtNumeroDos.Text))
                {
                    N1 = Convert.ToDouble(txtNumeroUno.Text);
                    N2 = Convert.ToDouble(txtNumeroDos.Text);

                    Resultado = N1 * N2;

                    DisplayAlert("El resultado es ", Resultado.ToString(), "Ok");
                }
                else
                {
                    DisplayAlert("Error", "La informacion es obligatoria en el campo Numero Dos", "Ok");
                }

            }
            else
            {
                DisplayAlert("Error", "La informacion es obligatoria en el campo Numero Uno", "Ok");
            }
        }
    }
}


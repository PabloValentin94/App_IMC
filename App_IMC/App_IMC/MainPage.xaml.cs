using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                double peso, altura;

                peso = double.Parse(txt_peso.Text);
                altura = double.Parse(txt_altura.Text);

                double imc = peso / (altura * altura);

                string classificacao = "";

                if (imc < 18.5)
                {

                    classificacao = "Abaixo do Peso";

                }

                else if (imc >= 18.5 && imc < 25)
                {

                    classificacao = "Peso Normal";

                }

                else if (imc >= 25 && imc < 30)
                {

                    classificacao = "Sobrepeso";

                }

                else if (imc >= 30 && imc < 35)
                {

                    classificacao = "Obesidade Grau I";

                }

                else if (imc >= 35 && imc < 40)
                {

                    classificacao = "Obesidade Grau II (Severa)";

                }

                else
                {

                    classificacao = "Obesidade Grau III (Mórbida)";

                }

                lbl_resultado.Text = "Seu Índice de Massa Corporal é: \n" + imc.ToString(("0.00"));
                lbl_resultado.TextColor = Color.Red;
                lbl_resultado.HorizontalTextAlignment = TextAlignment.Center;

                lbl_classificacao.Text = "Sua Classificação do I.M.C. é: \n" + classificacao + ".";
                lbl_classificacao.TextColor = Color.Blue;
                lbl_classificacao.HorizontalTextAlignment = TextAlignment.Center;

            } catch (Exception ex)
              {
                    DisplayAlert("Atenção", ex.Message, "OK");
              }

        }
    }
}

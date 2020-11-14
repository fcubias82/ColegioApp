using ColegioApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColegioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "usuario" && txtContrasenia.Text == "123456")
            {
                Navigation.InsertPageBefore(new MainPage(),this);
                await Navigation.PopAsync();                        
            }
            else
            {
                await DisplayAlert("Error", "Usuario ó contraseña incorrectos", "OK");
            }
        }
    }
}
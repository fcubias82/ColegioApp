using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ColegioApp.Models;

namespace ColegioApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearAlumnoPage : ContentPage
    {
        public CrearAlumnoPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                ID = 0,
                Codigo = enCodigo.Text,
                Apellido = enApellido.Text,
                Nombre = enNombre.Text
            };

            int iResultado = await App.Database.SaveAlumnoAsync(alumno);

            if(iResultado > 0)
            {
                await DisplayAlert("Crear", "Alumno ingresado satisfactoriamente", "OK");
                await Navigation.PopAsync();
            }

        }
    }
}
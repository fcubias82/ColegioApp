using ColegioApp.DependencyServices;
using ColegioApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ColegioApp.Views;

namespace ColegioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            /*
            List<Alumno> ListaAlumnos = new List<Alumno>();
            ListaAlumnos.Add(new Alumno
            {
                Codigo = "001",
                Nombre = "Fernando",
                Apellido = "Cubías"
            });

            ListaAlumnos.Add(new Alumno
            {
                Codigo = "002",
                Nombre = "Juan",
                Apellido = "Perez"
            });

            ListaAlumnos.Add(new Alumno
            {
                Codigo = "003",
                Nombre = "Reyna",
                Apellido = "Cortez"
            });

            lvAlumnos.ItemsSource = ListaAlumnos;
            */

            List<Alumno> ListaAlumnos = new List<Alumno>();
            ListaAlumnos = await App.Database.GetAlumnosAsync();
            lvAlumnos.ItemsSource = ListaAlumnos;


        }

        private async void btnPrueba_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlatformMessage>();
            string mensaje = service.GetMessage();
            await DisplayAlert("Prueba", mensaje, "OK");
        }

        private async void btnCrearAlumno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearAlumnoPage());
        }

        private async void lvAlumnos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Alumno alumno = (Alumno)e.SelectedItem;
            await Navigation.PushAsync(new ActualizarEliminarAlumnoPage(alumno));

        }
    }
}

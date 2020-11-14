using ColegioApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColegioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
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

        }
    }
}

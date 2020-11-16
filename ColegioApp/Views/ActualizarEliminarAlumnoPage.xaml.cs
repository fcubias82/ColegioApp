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
    public partial class ActualizarEliminarAlumnoPage : ContentPage
    {
        public Alumno alumno;
        public ActualizarEliminarAlumnoPage(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
            enCodigo.Text = alumno.Codigo;
            enNombre.Text = alumno.Nombre;
            enApellido.Text = alumno.Apellido;
            
        }
        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            alumno.Codigo = enCodigo.Text;
            alumno.Nombre = enNombre.Text;
            alumno.Apellido = enApellido.Text;
            int iResultado = await App.Database.SaveAlumnoAsync(alumno);

            if (iResultado > 0)
            {
                await DisplayAlert("Crear", "Alumno actualizado satisfactoriamente", "OK");                
            }
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
           if(await DisplayAlert("Eliminar","Esta seguro de eliminar el registro","OK","Cancelar"))
            {
                int iResultado = await App.Database.DeleteAlumnoAsync(alumno);
                if (iResultado > 0)
                {
                    await DisplayAlert("Eliminar", "Alumno eliminado satisfactoriamente", "OK");
                    await Navigation.PopAsync();
                }
            }                        
        }
    }
}
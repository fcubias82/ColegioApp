using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ColegioApp.ViewModels
{
    public  class LoginViewModel:BaseViewModel
    {


        public ICommand IngresarCommand { get; set; }


        public LoginViewModel()
        {
            IngresarCommand = new Command(async () => await ExecuteIngresarCommand());
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                OnPropertyChanged("Usuario");
            }
        }


        private string contrasenia;

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }


        async Task ExecuteIngresarCommand()
        {
            if(usuario == "usuario")
            {

            }
        }


    }
}

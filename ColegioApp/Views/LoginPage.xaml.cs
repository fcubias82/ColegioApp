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
        LoginViewModel context;
        public LoginPage()
        {
            InitializeComponent();
            
            BindingContext = context = new LoginViewModel();
            context.Navigation = Navigation;
        }        
    }
}
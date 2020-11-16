using ColegioApp.DependencyServices;
using ColegioApp.iOS.DependencyServices;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOSMessage))]
namespace ColegioApp.iOS.DependencyServices
{
    public class IOSMessage : IPlatformMessage
    {
        public string GetMessage()
        {
            return "Estoy en IOS";
        }
    }
}
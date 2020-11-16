using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ColegioApp.DependencyServices;
using ColegioApp.Droid.DependencyServices;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileHelper))]
namespace ColegioApp.Droid.DependencyServices
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}
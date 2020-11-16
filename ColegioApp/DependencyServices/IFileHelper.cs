using System;
using System.Collections.Generic;
using System.Text;

namespace ColegioApp.DependencyServices
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string FileName);
    }
}

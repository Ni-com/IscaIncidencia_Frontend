using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IscaIncidencia.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IscaIncidencia.Droid.Helper
{
    public class FileSystemServiceAndroid : IFileSystemService
    {
        public string GetPublicExternalStoragePath()
        {
            return Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
        }
    }
}
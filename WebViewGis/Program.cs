using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewGis
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            Chromium.InitChromiumBrowser();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}

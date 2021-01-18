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
using WebViewGis.Forms;

namespace WebViewGis
{
    static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Chromium.InitChromiumBrowser();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.EnableVisualStyles();
            if (args.Length > 0)
            {
                Application.Run(new MapForm2());
            }
            else
            {
                Application.Run(new MapForm());
            }

        }
    }
}

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
            AppDomain.CurrentDomain.AssemblyResolve += Resolver;
            Application.SetCompatibleTextRenderingDefault(true);
            Application.EnableVisualStyles();
            LoadApp();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void LoadApp()
        {
            Cef.EnableHighDPISupport();
            var settings = new CefSettings();
            settings.CachePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "cache");
            settings.CefCommandLineArgs.Add("enable-gpu", "1");
            settings.CefCommandLineArgs.Add("enable-webgl", "1");
            settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling", "1");
            settings.CefCommandLineArgs.Add("--off-screen-frame-rate", "60");
            // Set BrowserSubProcessPath based on app bitness at runtime
            settings.BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                   Environment.Is64BitProcess ? "x64" : "x86",
                                                   "CefSharp.BrowserSubprocess.exe");

            // Make sure you set performDependencyCheck false
            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);

            var browser = new Form1();


            Application.Run(browser);
        }

        // Will attempt to load missing assembly from either x86 or x64 subdir
        private static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("CefSharp"))
            {
                string assemblyName = args.Name.Split(new[] { ',' }, 2)[0] + ".dll";
                string archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                       Environment.Is64BitProcess ? "x64" : "x86",
                                                       assemblyName);

                return File.Exists(archSpecificPath)
                           ? Assembly.LoadFile(archSpecificPath)
                           : null;
            }

            return null;
        }

    }
}

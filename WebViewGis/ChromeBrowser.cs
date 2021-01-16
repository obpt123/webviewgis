using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewGis
{

    [DefaultProperty("Url")]
    public partial class ChromeBrowser : UserControl
    {
        private const string BLANK_URL = "about:blank";
        public ChromeBrowser()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }
        [DefaultValue(true)]
        public virtual bool DevMode { get; set; } = true;

        [DefaultValue(DockStyle.Fill)]
        public new DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }

        private string url = BLANK_URL;

        [DefaultValue(BLANK_URL)]
        public virtual string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                if (this.url != value)
                {
                    this.url = value;
                    if (this.webview != null)
                    {
                        this.webview.Load(string.IsNullOrEmpty(this.url) ? BLANK_URL : this.url);
                    }
                }
            }
        }

        ChromiumWebBrowser webview = null;

        [System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public ChromiumWebBrowser WebView
        {
            get { return webview; }
        }

        private void ChromeBrowser_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            if (this.webview == null)
            {
                string url = string.IsNullOrEmpty(this.url) ? BLANK_URL : this.url;
                webview = new ChromiumWebBrowser(url);
                webview.KeyboardHandler = new CEFKeyBoardHander(this);
                webview.Dock = DockStyle.Fill;
                this.Controls.Add(webview);
            }
        }

        private class CEFKeyBoardHander : IKeyboardHandler
        {

            private readonly ChromeBrowser chrome;

            public CEFKeyBoardHander(ChromeBrowser chrome)
            {
                this.chrome = chrome;
            }
            public bool OnKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
            {
                if (chrome.DevMode && type == KeyType.KeyUp && Enum.IsDefined(typeof(Keys), windowsKeyCode))
                {
                    var key = (Keys)windowsKeyCode;
                    switch (key)
                    {
                        case Keys.F12:
                            browser.ShowDevTools();
                            break;

                        case Keys.F5:

                            if (modifiers == CefEventFlags.ControlDown)
                            {
                                //MessageBox.Show("ctrl+f5");
                                browser.Reload(true); //强制忽略缓存

                            }
                            else
                            {
                                //MessageBox.Show("f5");
                                browser.Reload();
                            }
                            break;


                    }
                }
                return false;
            }

            public bool OnPreKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
            {
                return false;
            }
        }

        private void ChromeBrowser_Paint(object sender, PaintEventArgs e)
        {
            Point center = new Point(this.Width / 2, this.Height / 2);
            int size = 15;
            Point h1 = new Point(center.X, center.Y - size);
            Point h2 = new Point(center.X, center.Y + size);
            Point v1 = new Point(center.X - size, center.Y);
            Point v2 = new Point(center.X + size, center.Y);
            e.Graphics.DrawLine(Pens.Red, h1, h2);
            e.Graphics.DrawLine(Pens.Red, v1, v2);
        }

        public void ExecuteScriptAsync(string methodName, params object[] args)
        {
            this.webview.ExecuteScriptAsync(methodName, args);
        }
        public async Task<object> EvaluateScriptAsync(string methodName, params object[] args)
        {
            var result = await this.webview.EvaluateScriptAsync(methodName, args);
            return result.Result;
        }
    }
}

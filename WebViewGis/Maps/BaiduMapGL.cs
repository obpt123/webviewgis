using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewGis.Maps
{
    [DefaultProperty("")]
    public class BaiduMapGL : ChromiumBrowser
    {
        public event EventHandler<string> DataSelected;
        public BaiduMapGL()
        {
            this.Url = "http://localhost:5000/baidumapgl.html";
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Url { get => base.Url; set => base.Url = value; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaiduMapGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "BaiduMapGL";
            this.Size = new System.Drawing.Size(864, 543);
            this.ResumeLayout(false);

        }

        protected override void OnInitChromiumWebBrowser(ChromiumWebBrowser webBrowser)
        {
            base.OnInitChromiumWebBrowser(webBrowser);

            webBrowser.JavascriptObjectRepository.Register("callbackAsync", new CallBack(this), true, BindingOptions.DefaultBinder);
        }

        public class CallBack
        {
            private readonly BaiduMapGL host;

            public CallBack(BaiduMapGL host)
            {
                this.host = host;
            }
            public void RaiseEvent(string type, string jsonData)
            {
                if (host.DataSelected != null)
                {
                    host.DataSelected(host, jsonData);
                }

            }
        }


    }
}

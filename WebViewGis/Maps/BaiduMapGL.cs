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
    public class BaiduMapGL : ChromeBrowser
    {
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
            this.Size = new System.Drawing.Size(1267, 769);
            this.ResumeLayout(false);

        }

        protected override void OnInitChromiumWebBrowser(ChromiumWebBrowser webBrowser)
        {
            base.OnInitChromiumWebBrowser(webBrowser);

            webBrowser.JavascriptObjectRepository.Register("callbackAsync", new CallBack(), true, BindingOptions.DefaultBinder);
        }

        public class CallBack
        {
            public void SelectedPointsChanged(List<GeoPoint> points)
            {
                MessageBox.Show("Hello", "abc");
            }
        }

        public class GeoPoint
        {

            public double X { get; set; }
            public double Y { get; set; }
            public Dictionary<string, object> Props { get; set; }

        }
    }
}

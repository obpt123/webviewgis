using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewGis.Maps
{
    [DefaultProperty("")]
    public class BaiduMapGL : ChromeBrowser
    {
        public BaiduMapGL()
        {
            this.Url = (AppDomain.CurrentDomain.BaseDirectory + @"Maps/BaiduMapGL.html");
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Url { get => base.Url; set => base.Url = value; }


    }
}

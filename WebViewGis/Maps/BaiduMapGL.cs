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
            this.Size = new System.Drawing.Size(966, 663);
            this.ResumeLayout(false);

        }
    }
}

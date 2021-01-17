using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewGis.Controls
{
    public partial class MapControl : UserControl
    {
        public MapControl()
        {
            InitializeComponent();
        }

        private void MapControl_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            var baidumap = new Maps.BaiduMapGL();
            baidumap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(baidumap);
        }

    }
}

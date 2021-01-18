using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebViewGis.Maps;

namespace WebViewGis.Controls
{
    public partial class MapControl : UserControl
    {
        public event EventHandler<string> DataSelected;
        public MapControl()
        {
            InitializeComponent();
        }
        Maps.BaiduMapGL baidumap;
        private void MapControl_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            baidumap = new Maps.BaiduMapGL();
            baidumap.DataSelected += this.DataSelected;
            baidumap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(baidumap);
            this.cmb_style.DataSource = MapStyle.All;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            var name = control.Name;
            if (!name.StartsWith("btn_"))
            {
                MessageBox.Show("Invalid button Click.");
            }
            EnsureMapLoaded();
            var action = name.Substring(4, 1).ToLower() + name.Substring(5);
            this.baidumap.ExecuteScriptAsync(action);
        }

        private void EnsureMapLoaded()
        {
            if (baidumap == null)
            {
                MessageBox.Show("Map not loaded");
            }
        }

        public void LoadData(object datas)
        {
            EnsureMapLoaded();
            this.baidumap.ExecuteScriptAsync("loadPoint", datas.ToJsonString());
        }

        private void chk_show3d_ValueChanged(object sender, bool value)
        {
            if (this.chk_show3d.Checked)
            {
                this.baidumap.ExecuteScriptAsync("show3Dbuild");
            }
            else
            {
                this.baidumap.ExecuteScriptAsync("hide3Dbuild");
            }
        }

        private void uiComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = this.cmb_style.SelectedItem as MapStyle;
            if (item != null && this.baidumap != null)
            {
                this.baidumap.ExecuteScriptAsync("setStyle", item.StyleId);
            }
        }
    }
}

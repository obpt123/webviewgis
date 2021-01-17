using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebViewGis.Maps;

namespace WebViewGis.Forms
{
    public partial class MapForm : UIForm
    {
        public MapForm()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = System.IO.Path.GetFullPath("datas");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.LoadData(this.openFileDialog1.FileName);
            }
        }

        #region 
        public void LoadData(string file)
        {
            this.geoPointBindingSource.DataSource = Json.FromFile<List<GeoPoint>>(file);
        }
        #endregion

        private void geoPointBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void uiDoubleUpDown1_ValueChanged(object sender, double value)
        {

        }
    }
}

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
    public partial class MapForm2 : Form
    {
        public MapForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = System.IO.Path.GetFullPath("datas");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.LoadData(this.openFileDialog1.FileName);
            }
        }
        public void LoadData(string file)
        {
            var allText = System.IO.File.ReadAllText(file);
            var allPoints = Json.DeSerialize<List<GeoPoint>>(allText);
            this.mapControl1.LoadData(allPoints);
            this.chromiumBrowser1.ExecuteScriptAsync("loadData", allText);
        }
    }
}

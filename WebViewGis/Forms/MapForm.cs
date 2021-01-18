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
        private List<GeoPoint> allPoints = new List<GeoPoint>();
        public void LoadData(string file)
        {
            this.allPoints = Json.FromFile<List<GeoPoint>>(file);
            this.geoPointBindingSource.DataSource = this.allPoints.Where(p => p.Value >= this.uiDoubleUpDown1.Value);
        }
        #endregion

        private void geoPointBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void uiDoubleUpDown1_ValueChanged(object sender, double value)
        {
            this.geoPointBindingSource.DataSource = this.allPoints.Where(p => p.Value >= value);
        }

        private void geoPointBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.lbl_sourceCount.Text = this.geoPointBindingSource.Count.ToString();
            this.mapControl1.LoadData(this.geoPointBindingSource.DataSource);
        }

        private void mapControl1_DataSelected(object sender, string e)
        {
            var selected = Json.DeSerialize<List<GeoPoint>>(e);
            this.BeginInvoke(new Action(() =>
            {
                this.selectedBindingSource.DataSource = selected;
                this.LoadChart(selected);
            }));

        }

        private void selectedBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.lbl_targetCount.Text = this.selectedBindingSource.Count.ToString();
        }

        private void LoadChart(List<GeoPoint> points)
        {
            var charDatas = (from p in points
                             orderby p.Value
                             let name = ValueToName(p.Value)
                             group p by name into g
                             select new
                             {
                                 Name = g.Key,
                                 Count = g.Count()
                             }).ToList();
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "阶段统计";

            var series = new UIBarSeries();
            series.Name = "Bar1";
            foreach (var item in charDatas)
            {
                series.AddData(item.Count);
            }
            option.Series.Add(series);


            foreach (var item in charDatas)
            {
                option.XAxis.Data.Add(item.Name);
            }

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.Name = "阶段";
            option.YAxis.Name = "计数";

            this.uiBarChart1.SetOption(option);
        }
        private string ValueToName(double value)
        {
            if (value > 1000)
            {
                return "极大";
            }
            if (value < 100)
            {
                return "极小";
            }
            return (Math.Floor(value / 100) * 100).ToString();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            this.LoadChart(new List<GeoPoint>());
        }
    }
}

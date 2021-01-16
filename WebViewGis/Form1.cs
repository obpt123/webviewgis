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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("zoomIn");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("zoomOut");
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("to2dMap");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("to3dMap");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("beginDistance");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("endDistance");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("removeOverlays");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("setStyle", Maps.MapStyles.Light2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("setStyle", Maps.MapStyles.Dark2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("show3Dbuild");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("hide3Dbuild");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("clearPointLayer");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            LoadData("datas/data_1.json");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            LoadData("datas/data_200.json");
        }
        private void LoadData(string filePath)
        {
            var data = System.IO.File.ReadAllText(filePath);
            this.baiduMapGL1.ExecuteScriptAsync("loadPoint", data);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LoadData("datas/data_2000.json");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LoadData("datas/data_20000.json");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LoadData("datas/data_200000.json");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("drawCircle");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("closeDraw");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("clearSelected");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("selectAllPoints");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.baiduMapGL1.ExecuteScriptAsync("drawRectangle");
        }
    }
    public class GeoPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Dictionary<string, object> Props { get; set; }

    }


}

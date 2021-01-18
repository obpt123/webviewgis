
namespace WebViewGis.Forms
{
    partial class MapForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.chromiumBrowser1 = new WebViewGis.ChromiumBrowser();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mapControl1 = new WebViewGis.Controls.MapControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "加载数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chromiumBrowser1
            // 
            this.chromiumBrowser1.BackColor = System.Drawing.Color.White;
            this.chromiumBrowser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chromiumBrowser1.Location = new System.Drawing.Point(0, 70);
            this.chromiumBrowser1.Name = "chromiumBrowser1";
            this.chromiumBrowser1.Size = new System.Drawing.Size(174, 380);
            this.chromiumBrowser1.TabIndex = 1;
            this.chromiumBrowser1.Url = "http://localhost:5000/table.html";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(174, 70);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 380);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(179, 70);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(621, 380);
            this.mapControl1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "图元文件|*.json";
            this.openFileDialog1.InitialDirectory = "datas";
            this.openFileDialog1.Title = "选择数据";
            // 
            // MapForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.chromiumBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "MapForm2";
            this.Text = "MapForm2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private ChromiumBrowser chromiumBrowser1;
        private System.Windows.Forms.Splitter splitter1;
        private Controls.MapControl mapControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

namespace WebViewGis.Controls
{
    partial class MapControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.cmb_style = new Sunny.UI.UIComboBox();
            this.chk_show3d = new Sunny.UI.UICheckBox();
            this.btn_BeginDistance = new Sunny.UI.UISymbolButton();
            this.btn_MeasureCircleArea = new Sunny.UI.UISymbolButton();
            this.btn_MeasureRectangleArea = new Sunny.UI.UISymbolButton();
            this.btn_MeasurePolygonArea = new Sunny.UI.UISymbolButton();
            this.btn_RemoveOverlays = new Sunny.UI.UISymbolButton();
            this.btn_SelectByCircle = new Sunny.UI.UISymbolButton();
            this.btn_SelectByRectangle = new Sunny.UI.UISymbolButton();
            this.btn_SelectAllPoints = new Sunny.UI.UISymbolButton();
            this.btn_ClearSelected = new Sunny.UI.UISymbolButton();
            this.btn_ZoomIn = new Sunny.UI.UISymbolButton();
            this.btn_ZoomOut = new Sunny.UI.UISymbolButton();
            this.btn_BringDataToScreen = new Sunny.UI.UISymbolButton();
            this.btn_To2dMap = new Sunny.UI.UISymbolButton();
            this.btn_To3dMap = new Sunny.UI.UISymbolButton();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            panel1.Controls.Add(this.cmb_style);
            panel1.Controls.Add(this.chk_show3d);
            panel1.Location = new System.Drawing.Point(605, 6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(203, 35);
            panel1.TabIndex = 1;
            // 
            // cmb_style
            // 
            this.cmb_style.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_style.DisplayMember = "Name";
            this.cmb_style.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_style.FillColor = System.Drawing.Color.White;
            this.cmb_style.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_style.Location = new System.Drawing.Point(108, 4);
            this.cmb_style.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_style.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_style.Size = new System.Drawing.Size(94, 29);
            this.cmb_style.TabIndex = 1;
            this.cmb_style.Text = "风格";
            this.cmb_style.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.uiComboBox1_SelectedValueChanged);
            // 
            // chk_show3d
            // 
            this.chk_show3d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_show3d.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chk_show3d.Location = new System.Drawing.Point(3, 4);
            this.chk_show3d.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk_show3d.Name = "chk_show3d";
            this.chk_show3d.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk_show3d.Size = new System.Drawing.Size(101, 29);
            this.chk_show3d.TabIndex = 0;
            this.chk_show3d.Text = "显示建筑";
            this.chk_show3d.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.chk_show3d_ValueChanged);
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel3);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(811, 49);
            panel2.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(this.btn_BeginDistance);
            flowLayoutPanel3.Controls.Add(this.btn_MeasureCircleArea);
            flowLayoutPanel3.Controls.Add(this.btn_MeasureRectangleArea);
            flowLayoutPanel3.Controls.Add(this.btn_MeasurePolygonArea);
            flowLayoutPanel3.Controls.Add(this.btn_RemoveOverlays);
            flowLayoutPanel3.Location = new System.Drawing.Point(342, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(181, 41);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // btn_BeginDistance
            // 
            this.btn_BeginDistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BeginDistance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_BeginDistance.Location = new System.Drawing.Point(3, 3);
            this.btn_BeginDistance.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_BeginDistance.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_BeginDistance.Name = "btn_BeginDistance";
            this.btn_BeginDistance.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.btn_BeginDistance.Size = new System.Drawing.Size(35, 35);
            this.btn_BeginDistance.Symbol = 48;
            this.btn_BeginDistance.TabIndex = 5;
            this.btn_BeginDistance.TipsText = "测量距离";
            this.btn_BeginDistance.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_MeasureCircleArea
            // 
            this.btn_MeasureCircleArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MeasureCircleArea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_MeasureCircleArea.Location = new System.Drawing.Point(38, 3);
            this.btn_MeasureCircleArea.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_MeasureCircleArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_MeasureCircleArea.Name = "btn_MeasureCircleArea";
            this.btn_MeasureCircleArea.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_MeasureCircleArea.Size = new System.Drawing.Size(35, 35);
            this.btn_MeasureCircleArea.Symbol = 61915;
            this.btn_MeasureCircleArea.TabIndex = 0;
            this.btn_MeasureCircleArea.TipsText = "测量圆面积";
            this.btn_MeasureCircleArea.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_MeasureRectangleArea
            // 
            this.btn_MeasureRectangleArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MeasureRectangleArea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_MeasureRectangleArea.Location = new System.Drawing.Point(73, 3);
            this.btn_MeasureRectangleArea.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_MeasureRectangleArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_MeasureRectangleArea.Name = "btn_MeasureRectangleArea";
            this.btn_MeasureRectangleArea.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_MeasureRectangleArea.Size = new System.Drawing.Size(35, 35);
            this.btn_MeasureRectangleArea.Symbol = 61590;
            this.btn_MeasureRectangleArea.TabIndex = 1;
            this.btn_MeasureRectangleArea.TipsText = "测量矩形面积";
            this.btn_MeasureRectangleArea.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_MeasurePolygonArea
            // 
            this.btn_MeasurePolygonArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MeasurePolygonArea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_MeasurePolygonArea.Location = new System.Drawing.Point(108, 3);
            this.btn_MeasurePolygonArea.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_MeasurePolygonArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_MeasurePolygonArea.Name = "btn_MeasurePolygonArea";
            this.btn_MeasurePolygonArea.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_MeasurePolygonArea.Size = new System.Drawing.Size(35, 35);
            this.btn_MeasurePolygonArea.Symbol = 61446;
            this.btn_MeasurePolygonArea.TabIndex = 2;
            this.btn_MeasurePolygonArea.TipsText = "测量多边形面积";
            this.btn_MeasurePolygonArea.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_RemoveOverlays
            // 
            this.btn_RemoveOverlays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveOverlays.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_RemoveOverlays.Location = new System.Drawing.Point(143, 3);
            this.btn_RemoveOverlays.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_RemoveOverlays.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_RemoveOverlays.Name = "btn_RemoveOverlays";
            this.btn_RemoveOverlays.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.btn_RemoveOverlays.Size = new System.Drawing.Size(35, 35);
            this.btn_RemoveOverlays.Symbol = 57369;
            this.btn_RemoveOverlays.TabIndex = 4;
            this.btn_RemoveOverlays.TipsText = "清空测量图层";
            this.btn_RemoveOverlays.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(this.btn_SelectByCircle);
            flowLayoutPanel2.Controls.Add(this.btn_SelectByRectangle);
            flowLayoutPanel2.Controls.Add(this.btn_SelectAllPoints);
            flowLayoutPanel2.Controls.Add(this.btn_ClearSelected);
            flowLayoutPanel2.Location = new System.Drawing.Point(190, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(146, 41);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // btn_SelectByCircle
            // 
            this.btn_SelectByCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectByCircle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SelectByCircle.Location = new System.Drawing.Point(3, 3);
            this.btn_SelectByCircle.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_SelectByCircle.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_SelectByCircle.Name = "btn_SelectByCircle";
            this.btn_SelectByCircle.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.btn_SelectByCircle.Size = new System.Drawing.Size(35, 35);
            this.btn_SelectByCircle.Symbol = 61915;
            this.btn_SelectByCircle.TabIndex = 0;
            this.btn_SelectByCircle.TipsText = "圆形选择";
            this.btn_SelectByCircle.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_SelectByRectangle
            // 
            this.btn_SelectByRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectByRectangle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SelectByRectangle.Location = new System.Drawing.Point(38, 3);
            this.btn_SelectByRectangle.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_SelectByRectangle.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_SelectByRectangle.Name = "btn_SelectByRectangle";
            this.btn_SelectByRectangle.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_SelectByRectangle.Size = new System.Drawing.Size(35, 35);
            this.btn_SelectByRectangle.Symbol = 61590;
            this.btn_SelectByRectangle.TabIndex = 1;
            this.btn_SelectByRectangle.TipsText = "矩形选择";
            this.btn_SelectByRectangle.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_SelectAllPoints
            // 
            this.btn_SelectAllPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectAllPoints.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SelectAllPoints.Location = new System.Drawing.Point(73, 3);
            this.btn_SelectAllPoints.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_SelectAllPoints.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_SelectAllPoints.Name = "btn_SelectAllPoints";
            this.btn_SelectAllPoints.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_SelectAllPoints.Size = new System.Drawing.Size(35, 35);
            this.btn_SelectAllPoints.Symbol = 62023;
            this.btn_SelectAllPoints.TabIndex = 3;
            this.btn_SelectAllPoints.TipsText = "全部选中";
            this.btn_SelectAllPoints.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_ClearSelected
            // 
            this.btn_ClearSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClearSelected.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ClearSelected.Location = new System.Drawing.Point(108, 3);
            this.btn_ClearSelected.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_ClearSelected.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ClearSelected.Name = "btn_ClearSelected";
            this.btn_ClearSelected.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.btn_ClearSelected.Size = new System.Drawing.Size(35, 35);
            this.btn_ClearSelected.Symbol = 61735;
            this.btn_ClearSelected.TabIndex = 4;
            this.btn_ClearSelected.TipsText = "清空选中";
            this.btn_ClearSelected.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(this.btn_ZoomIn);
            flowLayoutPanel1.Controls.Add(this.btn_ZoomOut);
            flowLayoutPanel1.Controls.Add(this.btn_BringDataToScreen);
            flowLayoutPanel1.Controls.Add(this.btn_To2dMap);
            flowLayoutPanel1.Controls.Add(this.btn_To3dMap);
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(181, 41);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ZoomIn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ZoomIn.Location = new System.Drawing.Point(3, 3);
            this.btn_ZoomIn.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_ZoomIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.btn_ZoomIn.Size = new System.Drawing.Size(35, 35);
            this.btn_ZoomIn.Symbol = 61454;
            this.btn_ZoomIn.TabIndex = 0;
            this.btn_ZoomIn.TagString = "";
            this.btn_ZoomIn.TipsText = "放大地图";
            this.btn_ZoomIn.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ZoomOut.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ZoomOut.Location = new System.Drawing.Point(38, 3);
            this.btn_ZoomOut.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_ZoomOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_ZoomOut.Size = new System.Drawing.Size(35, 35);
            this.btn_ZoomOut.Symbol = 61456;
            this.btn_ZoomOut.TabIndex = 1;
            this.btn_ZoomOut.TipsText = "缩小地图";
            this.btn_ZoomOut.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_BringDataToScreen
            // 
            this.btn_BringDataToScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BringDataToScreen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_BringDataToScreen.Location = new System.Drawing.Point(73, 3);
            this.btn_BringDataToScreen.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_BringDataToScreen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_BringDataToScreen.Name = "btn_BringDataToScreen";
            this.btn_BringDataToScreen.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_BringDataToScreen.Size = new System.Drawing.Size(35, 35);
            this.btn_BringDataToScreen.Symbol = 61505;
            this.btn_BringDataToScreen.TabIndex = 2;
            this.btn_BringDataToScreen.TipsText = "定位到数据区域";
            this.btn_BringDataToScreen.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_To2dMap
            // 
            this.btn_To2dMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_To2dMap.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_To2dMap.Location = new System.Drawing.Point(108, 3);
            this.btn_To2dMap.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_To2dMap.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_To2dMap.Name = "btn_To2dMap";
            this.btn_To2dMap.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_To2dMap.Size = new System.Drawing.Size(35, 35);
            this.btn_To2dMap.Symbol = 57354;
            this.btn_To2dMap.TabIndex = 3;
            this.btn_To2dMap.TipsText = "2D模式";
            this.btn_To2dMap.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // btn_To3dMap
            // 
            this.btn_To3dMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_To3dMap.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_To3dMap.Location = new System.Drawing.Point(143, 3);
            this.btn_To3dMap.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_To3dMap.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_To3dMap.Name = "btn_To3dMap";
            this.btn_To3dMap.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.btn_To3dMap.Size = new System.Drawing.Size(35, 35);
            this.btn_To3dMap.Symbol = 57571;
            this.btn_To3dMap.TabIndex = 4;
            this.btn_To3dMap.TipsText = "3D模式";
            this.btn_To3dMap.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(panel2);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(811, 407);
            this.Load += new System.EventHandler(this.MapControl_Load);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton btn_BeginDistance;
        private Sunny.UI.UISymbolButton btn_MeasureCircleArea;
        private Sunny.UI.UISymbolButton btn_MeasureRectangleArea;
        private Sunny.UI.UISymbolButton btn_MeasurePolygonArea;
        private Sunny.UI.UISymbolButton btn_RemoveOverlays;
        private Sunny.UI.UISymbolButton btn_SelectByCircle;
        private Sunny.UI.UISymbolButton btn_SelectByRectangle;
        private Sunny.UI.UISymbolButton btn_SelectAllPoints;
        private Sunny.UI.UISymbolButton btn_ClearSelected;
        private Sunny.UI.UISymbolButton btn_ZoomIn;
        private Sunny.UI.UISymbolButton btn_ZoomOut;
        private Sunny.UI.UISymbolButton btn_BringDataToScreen;
        private Sunny.UI.UISymbolButton btn_To2dMap;
        private Sunny.UI.UISymbolButton btn_To3dMap;
        private Sunny.UI.UICheckBox chk_show3d;
        private Sunny.UI.UIComboBox cmb_style;
    }
}

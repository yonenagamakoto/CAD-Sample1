namespace Sample1
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.rdoColumn = new System.Windows.Forms.RadioButton();
			this.rdoBeam = new System.Windows.Forms.RadioButton();
			this.rdoHBrace = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dp = new CNET.DrawingPanel();
			this.rdoText = new System.Windows.Forms.RadioButton();
			this.rdoDimension = new System.Windows.Forms.RadioButton();
			this.btnChange = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dp)).BeginInit();
			this.SuspendLayout();
			// 
			// rdoColumn
			// 
			this.rdoColumn.Location = new System.Drawing.Point(10, 30);
			this.rdoColumn.Name = "rdoColumn";
			this.rdoColumn.Size = new System.Drawing.Size(80, 20);
			this.rdoColumn.TabIndex = 1;
			this.rdoColumn.Text = "柱";
			this.rdoColumn.UseVisualStyleBackColor = true;
			// 
			// rdoBeam
			// 
			this.rdoBeam.Checked = true;
			this.rdoBeam.Location = new System.Drawing.Point(10, 60);
			this.rdoBeam.Name = "rdoBeam";
			this.rdoBeam.Size = new System.Drawing.Size(80, 20);
			this.rdoBeam.TabIndex = 2;
			this.rdoBeam.TabStop = true;
			this.rdoBeam.Text = "梁";
			this.rdoBeam.UseVisualStyleBackColor = true;
			// 
			// rdoHBrace
			// 
			this.rdoHBrace.Location = new System.Drawing.Point(10, 90);
			this.rdoHBrace.Name = "rdoHBrace";
			this.rdoHBrace.Size = new System.Drawing.Size(80, 20);
			this.rdoHBrace.TabIndex = 3;
			this.rdoHBrace.Text = "水平ﾌﾞﾚｰｽ";
			this.rdoHBrace.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(10, 200);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "追加";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(10, 230);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "削除";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// dp
			// 
			this.dp.AddGridLine = true;
			this.dp.AllowMove = false;
			this.dp.AllowObjectMove = false;
			this.dp.AllowResize = false;
			this.dp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dp.AreaZoom = false;
			this.dp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dp.BottomMargin = 50;
			this.dp.CheckApplicationName = false;
			this.dp.DrawingMode = CNET.DrawingModeEnum.HighQuality;
			this.dp.DrawingRatio = 0F;
			this.dp.DrawingScale = 0F;
			this.dp.GridLineColor = System.Drawing.Color.White;
			this.dp.GridLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.dp.GridLineVisible = true;
			this.dp.GridLineWidth = 1F;
			this.dp.GridShadowColor = System.Drawing.Color.DarkGray;
			this.dp.HighSpeedSnap = true;
			this.dp.ImageData = null;
			this.dp.ImageDensity = 1F;
			this.dp.ImageOrigin = ((System.Drawing.PointF)(resources.GetObject("dp.ImageOrigin")));
			this.dp.ImageSize = new System.Drawing.Size(0, 0);
			this.dp.IsMoving = false;
			this.dp.IsResizing = false;
			this.dp.IsSnapFree = false;
			this.dp.LastDrawArcLayers = null;
			this.dp.LastDrawCircleLayers = null;
			this.dp.LastDrawDimensionLayers = null;
			this.dp.LastDrawLineLayers = null;
			this.dp.LastDrawPointLayers = null;
			this.dp.LastDrawPolygonLayers = null;
			this.dp.LastDrawPolylineLayers = null;
			this.dp.LastDrawRectangleLayers = null;
			this.dp.LastDrawStringLayers = null;
			this.dp.LastDrawTableLayers = null;
			this.dp.LeftMargin = 50;
			this.dp.LicenseKey = "";
			this.dp.Location = new System.Drawing.Point(95, 5);
			this.dp.MarkerColor = System.Drawing.Color.Black;
			this.dp.MarkerFill = true;
			this.dp.MarkerRect = new System.Drawing.Rectangle[] {
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0),
        new System.Drawing.Rectangle(0, 0, 0, 0)};
			this.dp.MarkerShape = CNET.PointShapeEnum.Square;
			this.dp.MarkerSize = new System.Drawing.Size(10, 10);
			this.dp.MarkerStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.dp.MarkerWidth = 1F;
			this.dp.MaxUndo = 100;
			this.dp.MaxVertex = 100;
			this.dp.MinusXGrid = 0;
			this.dp.MinusYGrid = 0;
			this.dp.Mode = CNET.ModeEnum.Neutral;
			this.dp.Name = "dp";
			this.dp.Object = "";
			this.dp.OfflineCode = "";
			this.dp.OffsetX = 0F;
			this.dp.OffsetY = 0F;
			this.dp.Ratio = 0.03067766F;
			this.dp.RedoFileName = "";
			this.dp.RightAngleOnly = false;
			this.dp.RightMargin = 50;
			this.dp.SelectMode = CNET.SelectModeEnum.Single;
			this.dp.SerialCode = "";
			this.dp.ShowCenterMarker = false;
			this.dp.ShowConerMarker = false;
			this.dp.ShowMidMarker = false;
			this.dp.Size = new System.Drawing.Size(700, 435);
			this.dp.SnapCrossPoint = false;
			this.dp.SnapDimensionEnd = false;
			this.dp.SnapGuideRectangleVertex = false;
			this.dp.SnapLineEnd = false;
			this.dp.SnapMode = CNET.SnapModeEnum.Default;
			this.dp.SnapPointObject = false;
			this.dp.SnapPolygonSideCrossPoint = false;
			this.dp.SnapPolygonVertex = false;
			this.dp.SnapRectangleVertex = false;
			this.dp.StretchPointSize = new System.Drawing.SizeF(50F, 50F);
			this.dp.TabIndex = 0;
			this.dp.TableTemp = null;
			this.dp.TabStop = false;
			this.dp.TextRatio = 0.75F;
			this.dp.TopMargin = 50;
			this.dp.TrimR = 500F;
			this.dp.UndoFileName = "";
			this.dp.UseRightClick = false;
			this.dp.X = 0F;
			this.dp.XGrid = 24;
			this.dp.XMax = 10920F;
			this.dp.XPitch = 455F;
			this.dp.Y = 0F;
			this.dp.YGrid = 24;
			this.dp.YMax = 10920F;
			this.dp.YPitch = 455F;
			this.dp.ZoomingRatio = 1F;
			// 
			// rdoText
			// 
			this.rdoText.Location = new System.Drawing.Point(10, 150);
			this.rdoText.Name = "rdoText";
			this.rdoText.Size = new System.Drawing.Size(80, 20);
			this.rdoText.TabIndex = 6;
			this.rdoText.Text = "ﾃｷｽﾄ";
			this.rdoText.UseVisualStyleBackColor = true;
			// 
			// rdoDimension
			// 
			this.rdoDimension.Location = new System.Drawing.Point(10, 120);
			this.rdoDimension.Name = "rdoDimension";
			this.rdoDimension.Size = new System.Drawing.Size(80, 20);
			this.rdoDimension.TabIndex = 7;
			this.rdoDimension.Text = "寸法線";
			this.rdoDimension.UseVisualStyleBackColor = true;
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(10, 260);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 8;
			this.btnChange.Text = "変更";
			this.btnChange.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.rdoDimension);
			this.Controls.Add(this.rdoText);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rdoHBrace);
			this.Controls.Add(this.rdoBeam);
			this.Controls.Add(this.rdoColumn);
			this.Controls.Add(this.dp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CNET.DrawingPanel dp;
		private System.Windows.Forms.RadioButton rdoColumn;
		private System.Windows.Forms.RadioButton rdoBeam;
		private System.Windows.Forms.RadioButton rdoHBrace;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.RadioButton rdoText;
		private System.Windows.Forms.RadioButton rdoDimension;
		private System.Windows.Forms.Button btnChange;
	}
}


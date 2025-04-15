using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CNET;

namespace Sample1
{
	public partial class Form1 : Form
	{
		private string _Obj = "";//選択オブジェクト
		private string _Mode = "";//モード

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//PointObjectの初期設定
			dp.Points.Shape = PointShapeEnum.H;
			dp.Points.Size = new SizeF(400, 400);
			dp.Points.Width = 2;
			dp.Points.Color = Color.Red;
			//LineObjectの初期設定
			dp.Lines.Thickness = 250;
			dp.Lines.Color = Color.Blue;
			dp.Lines.Width = 1;
			dp.Lines.ExtLeftLength = -200;
			dp.Lines.ExtRightLength = -200;
			//RadioButtonのCheckedChangedイベント
			rdoColumn.CheckedChanged += Rdo_CheckedChanged;
			rdoBeam.CheckedChanged += Rdo_CheckedChanged;
			rdoHBrace.CheckedChanged += Rdo_CheckedChanged;
			rdoDimension.CheckedChanged += Rdo_CheckedChanged;
			rdoText.CheckedChanged += Rdo_CheckedChanged;
			//ButtonのClickイベント
			btnAdd.Click += BtnAdd_Click;
			btnDelete.Click += BtnDelete_Click;
			btnChange.Click += BtnChange_Click;
			//DrawingPanelのDrawnイベント
			dp.RectangleDrawn += Dp_RectangleDrawn;
			dp.DimensionDrawn += Dp_DimensionDrawn;
			//DrawingPanelのSelectedイベント
			dp.PointSelected += Dp_PointSelected;
			dp.LineSelected += Dp_LineSelected;
			dp.DimensionSelected += Dp_DimensionSelected;
			dp.StringSelected += Dp_StringSelected;
			//DrawingPanelの入力キャンセル処理イベント
			dp.MouseUp += Dp_MouseUp;
		}

		private void Rdo_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rdo = (RadioButton)sender;
			if (!rdo.Checked) return;
			//オブジェクトをセット
			if (rdo == rdoColumn)
				_Obj = "Column";
			else if (rdo == rdoBeam)
				_Obj = "Beam";
			else if (rdo == rdoHBrace)
				_Obj = "HBrace";
			else if (rdo == rdoDimension)
				_Obj = "Dimension";
			else if (rdo == rdoText)
				_Obj = "Text";
			//モードに応じてイベントハンドラーへ
			if (_Mode == "Add")
				this.BtnAdd_Click(rdo, EventArgs.Empty);
			else if (_Mode == "Delete")
				this.BtnDelete_Click(rdo, EventArgs.Empty);
			else if (_Mode == "Change")
				this.BtnChange_Click(rdo, EventArgs.Empty);
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			_Mode = "Add";
			//DrawingPanelのモードを設定
			if (_Obj == "Column")
				dp.Mode = ModeEnum.DrawPoint;
			else if (_Obj == "Beam")
				dp.Mode = ModeEnum.DrawLine;
			else if (_Obj == "HBrace")
				dp.Mode = ModeEnum.DrawRectangle;
			else if (_Obj == "Dimension")
				dp.Mode = ModeEnum.DrawDimension;
			else if (_Obj == "Text")
			{
				dp.Mode = ModeEnum.DrawString;
				//テキスト入力
				string text = Interaction.InputBox("テキストを入力して下さい。", "テキスト");
				if (text != "")
				{
					//dp.StringBufferにStringObjectを追加
					dp.StringBuffer.Add(text, 0, new Font("ＭＳ ゴシック", 9));
				}
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			_Mode = "Delete";
			//DrawingPanelのモードを設定
			if (_Obj == "Column")
				dp.Mode = ModeEnum.RemovePoint;
			else if (_Obj == "Beam")
				dp.Mode = ModeEnum.RemoveLine;
			else if (_Obj == "HBrace")
				dp.Mode = ModeEnum.RemoveRectangle;
			else if (_Obj == "Dimension")
				dp.Mode = ModeEnum.RemoveDimension;
			else if (_Obj == "Text")
				dp.Mode = ModeEnum.RemoveString;
		}

		private void BtnChange_Click(object sender, EventArgs e)
		{
			_Mode = "Change";
			//DrawingPanelのモードを設定
			if (_Obj == "Column")
				dp.Mode = ModeEnum.SelectPoint;
			else if (_Obj == "Beam")
				dp.Mode = ModeEnum.SelectLine;
			else if (_Obj == "HBrace")
				dp.Mode = ModeEnum.SelectLine;
			else if (_Obj == "Dimension")
				dp.Mode = ModeEnum.SelectDimension;
			else if (_Obj == "Text")
				dp.Mode = ModeEnum.SelectString;
		}

		private void Dp_MouseUp(object sender, MouseEventArgs e)
		{
			//右ボタンクリックで入力キャンセル
			if (e.Button == MouseButtons.Right)
			{
				//PointBufferをクリアしてラバーバンドを消去する
				dp.ClearPointBuffer();
				dp.RectRubberBand.Erase();
			}
		}

		private void Dp_RectangleDrawn(object sender, ObjectDrawnEventArgs e)
		{
			if (_Obj != "HBrace") return;
			//Rectanglesコレクションの中からカレントオブジェクトを取得する
			RectangleObject rect = dp.Rectangles[e.Index];
			//rectの右上りの対角線を取得し、Linesコレクションに追加する
			LineObject hb1 = rect.DiagonalUpward;
			hb1.Color = Color.DarkGray;
			hb1.Style = System.Drawing.Drawing2D.DashStyle.Dot;
			hb1.Width = 2;
			dp.Lines.Add(hb1);
			//rectの右下りの対角線を取得し、Linesコレクションに追加する
			LineObject hb2 = rect.DiagonalDownward;
			hb2.Color = Color.DarkGray;
			hb2.Style = System.Drawing.Drawing2D.DashStyle.Dot;
			hb2.Width = 2;
			dp.Lines.Add(hb2);
			//rectを削除する
			dp.Rectangles.Remove(rect);
		}

		private void Dp_DimensionDrawn(object sender, ObjectDrawnEventArgs e)
		{
			if (_Obj == "Dimension")
			{
				//Dimensionsコレクションの中からカレントオブジェクトを取得する
				DimensionObject dim = dp.Dimensions[e.Index];
				//寸法値を編集させる
				string value = Interaction.InputBox("寸法値を入力して下さい。", "寸法線", dim.Text);
				if (value != "")
				{
					dim.Text = value;
				}
			}
		}

		private void Dp_PointSelected(object sender, ObjectSelectedEventArgs e)
		{
			if (_Obj == "Column")
			{
				//Pointsコレクションの中からカレントオブジェクトを取得する
				PointObject column = dp.Points[e.Index];
				if (dp.Mode == ModeEnum.SelectPoint)
				{
					//モードがSelectPointであれば、柱形状を変更する
					if (column.Shape == PointShapeEnum.H)
						column.Shape = PointShapeEnum.Square;
					else
						column.Shape = PointShapeEnum.H;
				}
				else if (dp.Mode == ModeEnum.RemovePoint)
				{
					//モードがRemovePointであれば、柱を削除する
					dp.Points.Remove(column);
				}
			}
			//SelectedPointsコレクション内のオブジェクトを削除する
			dp.ClearSelectedObject();
		}

		private void Dp_LineSelected(object sender, ObjectSelectedEventArgs e)
		{
			if (_Obj == "Beam")
			{
				//Linesコレクションの中からカレントオブジェクトを取得する
				LineObject beam = dp.Lines[e.Index];
				if (dp.Mode == ModeEnum.SelectLine)
				{
					//モードがSelectLineであれば、梁幅と塗り潰し色を変更する
					if (beam.Thickness == 250)
					{
						beam.Thickness = 350;
						beam.IsFill = true;
						beam.FillColor = Color.SkyBlue;
					}
					else
					{
						beam.Thickness = 250;
						beam.IsFill = false;
					}
				}
				else
				{
					//モードがRemoveLineであれば、梁を削除する
					dp.Lines.Remove(beam);
				}
			}
			else if (_Obj == "HBrace")
			{
				//Linesコレクションの中からカレントオブジェクトを取得する
				LineObject hBrace = dp.Lines[e.Index];
				if (dp.Mode == ModeEnum.SelectLine)
				{
					//モードがSelectLineであれば、ブレース色を変更する
					if (hBrace.Color == Color.DarkGray)
						hBrace.Color = Color.Black;
					else
						hBrace.Color = Color.DarkGray;
				}
				else
				{
					//モードがRemoveLineであれば、ブレースを削除する
					dp.Lines.Remove(hBrace);
				}
			}
			//SelectedPointsコレクション内のオブジェクトを削除する
			dp.ClearSelectedObject();
		}

		private void Dp_DimensionSelected(object sender, ObjectSelectedEventArgs e)
		{
			if (_Obj == "Dimension")
			{
				//Dimensionsコレクションの中からカレントオブジェクトを取得する
				DimensionObject dim = dp.Dimensions[e.Index];
				if (dp.Mode == ModeEnum.SelectDimension)
				{
					//モードがSelectDimensionであれば、寸法値を変更する
					string value = Interaction.InputBox("寸法値を入力して下さい。", "寸法線", dim.Text);
					if (value != "")
					{
						dim.Text = value;
					}
				}
				else if (dp.Mode == ModeEnum.RemoveDimension)
				{
					//モードがRemoveDimensionであれば、寸法線を削除する
					dp.Dimensions.Remove(dim);
				}
			}
			//SelectedPointsコレクション内のオブジェクトを削除する
			dp.ClearSelectedObject();
		}

		private void Dp_StringSelected(object sender, ObjectSelectedEventArgs e)
		{
			if (_Obj == "Text")
			{
				//Stringsコレクションの中からカレントオブジェクトを取得する
				StringObject s = dp.Strings[e.Index];
				if (dp.Mode == ModeEnum.SelectString)
				{
					//モードがSelectStringであれば、テキストを変更する
					string text = Interaction.InputBox("テキストを入力して下さい。", "テキスト", s.Text);
					if (text != "")
					{
						s.Text = text;
					}
				}
				else if (dp.Mode == ModeEnum.RemoveString)
				{
					//モードがRemoveStringであれば、テキストを削除する
					dp.Strings.Remove(s);
				}
			}
			//SelectedPointsコレクション内のオブジェクトを削除する
			dp.ClearSelectedObject();
		}
	}
}

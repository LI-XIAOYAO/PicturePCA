using Lxy.Picture.PCA;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PicturePCA
{
    public partial class MainForm : Form
    {
        private PCAResult _PCAResult;
        private int _pixelAmount;
        private bool _isFirst;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.ColorNum_Label.Text = (this.ColorNum_TrackBar.Value = this.ColorNum_TrackBar.Maximum).ToString();
            this.DeltaNum_Label.Text = (this.Delta_TrackBar.Value = 24).ToString();
            this.ThresholdValue_Label.Text = (this.ThresholdValue_TrackBar.Value = 30).ToString();
        }

        private void TrackBar_Enter(object sender, EventArgs e)
        {
            if (null != P_PictureBox.Image)
            {
                this.Analysis_Button.Focus();
            }
            else
            {
                this.OpenPic_Button.Focus();
            }
        }

        private void ColorNumText_TrackBar_Scroll(object sender, EventArgs e)
        {
            this.ColorNum_Label.Text = this.ColorNum_TrackBar.Value.ToString();

            Analysis_Button_Click(sender, e);
            ShowButton();
        }

        private void DeltaNumText_TrackBar_Scroll(object sender, EventArgs e)
        {
            this.DeltaNum_Label.Text = this.Delta_TrackBar.Value.ToString();

            Analysis_Button_Click(sender, e);
            ShowButton();
        }

        private void ThresholdValue_TrackBar_Scroll(object sender, EventArgs e)
        {
            this.ThresholdValue_Label.Text = this.ThresholdValue_TrackBar.Value.ToString();

            Analysis_Button_Click(sender, e);
            ShowButton();
        }

        private void OpenPic_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                RestoreDirectory = true,
                Filter = "*.jpg,*.png,*.jpeg,*.bmp,*.gif|*.jpg;*.png;*.jpeg;*.bmp;*.gif|All files(*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    P_PictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);

                    _isFirst = true;
                    _PCAResult = null;
                    this.ThresholdValue_Label.Text = (this.ThresholdValue_TrackBar.Value = 30).ToString();

                    Draw_PictureBox.Refresh();
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("          文件不存在");
                }
                catch (Exception)
                {
                    MessageBox.Show("         读取图片异常");
                }
            }

            if (null != P_PictureBox.Image)
            {
                this.OpenPic_Button.Visible = true;
                this.Analysis_Button.Enabled = true;
                this.Analysis_Button.Visible = true;
                this.Analysis_Button.Focus();
            }
            else
            {
                this.OpenPic_Button.Visible = true;
                this.Analysis_Button.Enabled = false;
                this.Analysis_Button.Visible = false;
            }
        }

        private void Analysis_Button_Click(object sender, EventArgs e)
        {
            if (P_PictureBox.Image != null)
            {
                Stopwatch Sw = new Stopwatch();
                Sw.Start();

                _PCAResult = Lxy.Picture.PCA.Image.Analysis(P_PictureBox.Image, ColorNum_TrackBar.Value, _isFirst && true, Delta_TrackBar.Value, ThresholdValue_TrackBar.Value);
                if (_isFirst && ThresholdValue_TrackBar.Value > _PCAResult.MaxThresholdValue && null != _PCAResult.HighlightColor)
                {
                    _isFirst = false;
                    ThresholdValue_TrackBar.Value = _PCAResult.MaxThresholdValue;
                    ThresholdValue_Label.Text = _PCAResult.MaxThresholdValue.ToString();
                }

                Sw.Stop();
                Elapsed_Label.Text = $"耗  时：   {Sw.ElapsedMilliseconds} ms";
                _pixelAmount = P_PictureBox.Image.Width * P_PictureBox.Image.Height;

                Draw_PictureBox.Refresh();
            }
        }

        private void Draw_PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Draw_PictureBox.BackColor);

            using Font font = new Font("宋体", 9f);
            SolidBrush B = new SolidBrush(Color.Black);
            e.Graphics.DrawString("颜色", font, B, new PointF(36, 0));
            e.Graphics.DrawString("ARGB", font, B, new PointF(142, 0));
            e.Graphics.DrawString("占比 ", font, B, new PointF(217, 0));
            e.Graphics.DrawString($"数量({_PCAResult?.ColorCount.ToString() ?? "-"})", font, B, new PointF(275, 0));
            B.Dispose();

            if (null != _PCAResult?.MajorColors)
            {
                _PCAResult.MajorColors.Insert(0, default);
                for (int i = 0; i < _PCAResult.MajorColors.Count; i++)
                {
                    if (0 == i)
                    {
                        B = new SolidBrush(_PCAResult.HighlightColor ?? Color.Gray);
                        e.Graphics.FillRectangle(B, new Rectangle(0, (i + 1) * 20, 100, 15));
                        e.Graphics.DrawString(_PCAResult.HighlightColor.HasValue ? $"#{B.Color.Name.ToUpper()}" : "请调整阈值", font, B, new PointF(130, (i + 1) * 20 + 3));
                        e.Graphics.DrawString("-", font, B, new PointF(225, (i + 1) * 20 + 3));
                        e.Graphics.DrawString("强调色", font, B, new PointF(280, (i + 1) * 20 + 3));
                    }
                    else
                    {
                        B = new SolidBrush(_PCAResult.MajorColors[i].Color);
                        var percentage = Math.Round(_PCAResult.MajorColors[i].Amount * 1D / _pixelAmount * 100, 2).ToString("F2").PadLeft(5, ' ');

                        e.Graphics.FillRectangle(B, new Rectangle(0, (i + 1) * 20, 100, 15));
                        e.Graphics.DrawString($"#{B.Color.Name.ToUpper()}", font, B, new PointF(130, (i + 1) * 20 + 3));
                        e.Graphics.DrawString(percentage, font, B, new PointF(215, (i + 1) * 20 + 3));
                        e.Graphics.DrawString(_PCAResult.MajorColors[i].Amount.ToString().PadLeft(5, ' '), font, B, new PointF(280, (i + 1) * 20 + 3));
                    }

                    B.Dispose();
                }
            }
        }

        private void Button_TransparentPanel_MouseEnter(object sender, EventArgs e)
        {
            if (null != P_PictureBox.Image)
            {
                this.OpenPic_Button.Visible = true;
                this.Analysis_Button.Enabled = true;
                this.Analysis_Button.Visible = true;
            }
            else
            {
                this.OpenPic_Button.Visible = true;
                this.Analysis_Button.Enabled = false;
                this.Analysis_Button.Visible = false;
            }
        }

        private void P_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.OpenPic_Button.Visible = null == P_PictureBox.Image;
            this.Analysis_Button.Visible = false;
        }

        private void ShowButton()
        {
            if (null != P_PictureBox.Image)
            {
                this.OpenPic_Button.Visible = false;
                this.Analysis_Button.Visible = false;
            }
            else
            {
                this.OpenPic_Button.Visible = true;
                this.Analysis_Button.Enabled = false;
                this.Analysis_Button.Visible = false;
            }
        }
    }
}
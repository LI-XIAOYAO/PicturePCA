
namespace PicturePCA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ColorNumText_Label = new System.Windows.Forms.Label();
            this.ColorNum_TrackBar = new System.Windows.Forms.TrackBar();
            this.ColorNum_Label = new System.Windows.Forms.Label();
            this.DeltaText_Label = new System.Windows.Forms.Label();
            this.DeltaNum_Label = new System.Windows.Forms.Label();
            this.Delta_TrackBar = new System.Windows.Forms.TrackBar();
            this.P_PictureBox = new System.Windows.Forms.PictureBox();
            this.Draw_PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenPic_Button = new System.Windows.Forms.Button();
            this.Analysis_Button = new System.Windows.Forms.Button();
            this.Button_TransparentPanel = new PicturePCA.TransparentPanel();
            this.Elapsed_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ThresholdValue_Label = new System.Windows.Forms.Label();
            this.ThresholdValue_TrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNum_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Draw_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdValue_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorNumText_Label
            // 
            this.ColorNumText_Label.AutoSize = true;
            this.ColorNumText_Label.Location = new System.Drawing.Point(19, 17);
            this.ColorNumText_Label.Name = "ColorNumText_Label";
            this.ColorNumText_Label.Size = new System.Drawing.Size(56, 17);
            this.ColorNumText_Label.TabIndex = 0;
            this.ColorNumText_Label.Text = "颜色数：";
            // 
            // ColorNum_TrackBar
            // 
            this.ColorNum_TrackBar.Location = new System.Drawing.Point(74, 17);
            this.ColorNum_TrackBar.Maximum = 20;
            this.ColorNum_TrackBar.Minimum = 1;
            this.ColorNum_TrackBar.Name = "ColorNum_TrackBar";
            this.ColorNum_TrackBar.Size = new System.Drawing.Size(386, 45);
            this.ColorNum_TrackBar.TabIndex = 1;
            this.ColorNum_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ColorNum_TrackBar.Value = 1;
            this.ColorNum_TrackBar.Scroll += new System.EventHandler(this.ColorNumText_TrackBar_Scroll);
            this.ColorNum_TrackBar.Enter += new System.EventHandler(this.TrackBar_Enter);
            // 
            // ColorNum_Label
            // 
            this.ColorNum_Label.AutoSize = true;
            this.ColorNum_Label.Location = new System.Drawing.Point(466, 17);
            this.ColorNum_Label.Name = "ColorNum_Label";
            this.ColorNum_Label.Size = new System.Drawing.Size(15, 17);
            this.ColorNum_Label.TabIndex = 0;
            this.ColorNum_Label.Text = "0";
            // 
            // DeltaText_Label
            // 
            this.DeltaText_Label.AutoSize = true;
            this.DeltaText_Label.Location = new System.Drawing.Point(25, 44);
            this.DeltaText_Label.Name = "DeltaText_Label";
            this.DeltaText_Label.Size = new System.Drawing.Size(50, 17);
            this.DeltaText_Label.TabIndex = 0;
            this.DeltaText_Label.Text = "Delta：";
            // 
            // DeltaNum_Label
            // 
            this.DeltaNum_Label.AutoSize = true;
            this.DeltaNum_Label.Location = new System.Drawing.Point(466, 45);
            this.DeltaNum_Label.Name = "DeltaNum_Label";
            this.DeltaNum_Label.Size = new System.Drawing.Size(15, 17);
            this.DeltaNum_Label.TabIndex = 0;
            this.DeltaNum_Label.Text = "0";
            // 
            // Delta_TrackBar
            // 
            this.Delta_TrackBar.Location = new System.Drawing.Point(74, 44);
            this.Delta_TrackBar.Maximum = 128;
            this.Delta_TrackBar.Minimum = 1;
            this.Delta_TrackBar.Name = "Delta_TrackBar";
            this.Delta_TrackBar.Size = new System.Drawing.Size(386, 45);
            this.Delta_TrackBar.TabIndex = 1;
            this.Delta_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Delta_TrackBar.Value = 1;
            this.Delta_TrackBar.Scroll += new System.EventHandler(this.DeltaNumText_TrackBar_Scroll);
            this.Delta_TrackBar.Enter += new System.EventHandler(this.TrackBar_Enter);
            // 
            // P_PictureBox
            // 
            this.P_PictureBox.Location = new System.Drawing.Point(12, 119);
            this.P_PictureBox.Name = "P_PictureBox";
            this.P_PictureBox.Size = new System.Drawing.Size(480, 320);
            this.P_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_PictureBox.TabIndex = 2;
            this.P_PictureBox.TabStop = false;
            this.P_PictureBox.MouseLeave += new System.EventHandler(this.P_PictureBox_MouseLeave);
            // 
            // Draw_PictureBox
            // 
            this.Draw_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Draw_PictureBox.Location = new System.Drawing.Point(524, 19);
            this.Draw_PictureBox.Name = "Draw_PictureBox";
            this.Draw_PictureBox.Size = new System.Drawing.Size(348, 435);
            this.Draw_PictureBox.TabIndex = 3;
            this.Draw_PictureBox.TabStop = false;
            this.Draw_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_PictureBox_Paint);
            // 
            // OpenPic_Button
            // 
            this.OpenPic_Button.Location = new System.Drawing.Point(205, 243);
            this.OpenPic_Button.Name = "OpenPic_Button";
            this.OpenPic_Button.Size = new System.Drawing.Size(75, 29);
            this.OpenPic_Button.TabIndex = 4;
            this.OpenPic_Button.Text = "Open";
            this.OpenPic_Button.UseVisualStyleBackColor = true;
            this.OpenPic_Button.Click += new System.EventHandler(this.OpenPic_Button_Click);
            // 
            // Analysis_Button
            // 
            this.Analysis_Button.Enabled = false;
            this.Analysis_Button.Location = new System.Drawing.Point(205, 278);
            this.Analysis_Button.Name = "Analysis_Button";
            this.Analysis_Button.Size = new System.Drawing.Size(75, 29);
            this.Analysis_Button.TabIndex = 4;
            this.Analysis_Button.Text = "Analysis";
            this.Analysis_Button.UseVisualStyleBackColor = true;
            this.Analysis_Button.Visible = false;
            this.Analysis_Button.Click += new System.EventHandler(this.Analysis_Button_Click);
            // 
            // Button_TransparentPanel
            // 
            this.Button_TransparentPanel.Location = new System.Drawing.Point(144, 225);
            this.Button_TransparentPanel.Name = "Button_TransparentPanel";
            this.Button_TransparentPanel.Opacity = 0;
            this.Button_TransparentPanel.Size = new System.Drawing.Size(200, 100);
            this.Button_TransparentPanel.TabIndex = 6;
            this.Button_TransparentPanel.MouseEnter += new System.EventHandler(this.Button_TransparentPanel_MouseEnter);
            // 
            // Elapsed_Label
            // 
            this.Elapsed_Label.AutoSize = true;
            this.Elapsed_Label.Location = new System.Drawing.Point(23, 100);
            this.Elapsed_Label.Name = "Elapsed_Label";
            this.Elapsed_Label.Size = new System.Drawing.Size(69, 17);
            this.Elapsed_Label.TabIndex = 0;
            this.Elapsed_Label.Text = "耗  时：   -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "阈  值：";
            // 
            // ThresholdValue_Label
            // 
            this.ThresholdValue_Label.AutoSize = true;
            this.ThresholdValue_Label.Location = new System.Drawing.Point(466, 73);
            this.ThresholdValue_Label.Name = "ThresholdValue_Label";
            this.ThresholdValue_Label.Size = new System.Drawing.Size(15, 17);
            this.ThresholdValue_Label.TabIndex = 0;
            this.ThresholdValue_Label.Text = "0";
            // 
            // ThresholdValue_TrackBar
            // 
            this.ThresholdValue_TrackBar.Location = new System.Drawing.Point(74, 72);
            this.ThresholdValue_TrackBar.Maximum = 360;
            this.ThresholdValue_TrackBar.Name = "ThresholdValue_TrackBar";
            this.ThresholdValue_TrackBar.Size = new System.Drawing.Size(386, 45);
            this.ThresholdValue_TrackBar.TabIndex = 1;
            this.ThresholdValue_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ThresholdValue_TrackBar.Value = 1;
            this.ThresholdValue_TrackBar.Scroll += new System.EventHandler(this.ThresholdValue_TrackBar_Scroll);
            this.ThresholdValue_TrackBar.Enter += new System.EventHandler(this.TrackBar_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Elapsed_Label);
            this.Controls.Add(this.Analysis_Button);
            this.Controls.Add(this.OpenPic_Button);
            this.Controls.Add(this.Draw_PictureBox);
            this.Controls.Add(this.ThresholdValue_TrackBar);
            this.Controls.Add(this.Delta_TrackBar);
            this.Controls.Add(this.ThresholdValue_Label);
            this.Controls.Add(this.ColorNum_TrackBar);
            this.Controls.Add(this.DeltaNum_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorNum_Label);
            this.Controls.Add(this.DeltaText_Label);
            this.Controls.Add(this.ColorNumText_Label);
            this.Controls.Add(this.Button_TransparentPanel);
            this.Controls.Add(this.P_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicturePCA";
            ((System.ComponentModel.ISupportInitialize)(this.ColorNum_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Draw_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdValue_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColorNumText_Label;
        private System.Windows.Forms.TrackBar ColorNum_TrackBar;
        private System.Windows.Forms.Label ColorNum_Label;
        private System.Windows.Forms.Label DeltaText_Label;
        private System.Windows.Forms.Label DeltaNum_Label;
        private System.Windows.Forms.TrackBar Delta_TrackBar;
        private System.Windows.Forms.PictureBox P_PictureBox;
        private System.Windows.Forms.PictureBox Draw_PictureBox;
        private System.Windows.Forms.Button OpenPic_Button;
        private System.Windows.Forms.Button Analysis_Button;
        private TransparentPanel Button_TransparentPanel;
        private System.Windows.Forms.Label Elapsed_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ThresholdValue_Label;
        private System.Windows.Forms.TrackBar ThresholdValue_TrackBar;
    }
}


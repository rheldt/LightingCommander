namespace LightingCommander.Controls
{
    partial class DarkFader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorSlider = new ColorSlider.ColorSlider();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorSlider
            // 
            this.colorSlider.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.colorSlider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.colorSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorSlider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorSlider.ElapsedPenColorTop = System.Drawing.Color.White;
            this.colorSlider.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSlider.ForeColor = System.Drawing.Color.DarkGray;
            this.colorSlider.LargeChange = ((uint)(5u));
            this.colorSlider.Location = new System.Drawing.Point(0, 0);
            this.colorSlider.Margin = new System.Windows.Forms.Padding(0);
            this.colorSlider.Maximum = 255;
            this.colorSlider.Name = "colorSlider";
            this.colorSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider.ScaleDivisions = 10;
            this.colorSlider.ScaleSubDivisions = 1;
            this.colorSlider.ShowDivisionsText = true;
            this.colorSlider.ShowSmallScale = false;
            this.colorSlider.Size = new System.Drawing.Size(50, 200);
            this.colorSlider.SmallChange = ((uint)(1u));
            this.colorSlider.TabIndex = 1;
            this.colorSlider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorSlider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorSlider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSlider.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSlider.TickAdd = 0F;
            this.colorSlider.TickColor = System.Drawing.Color.White;
            this.colorSlider.TickDivide = 0F;
            this.colorSlider.Value = 0;
            // 
            // lblChannel
            // 
            this.lblChannel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannel.ForeColor = System.Drawing.Color.White;
            this.lblChannel.Location = new System.Drawing.Point(0, 200);
            this.lblChannel.Margin = new System.Windows.Forms.Padding(0);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(50, 20);
            this.lblChannel.TabIndex = 2;
            this.lblChannel.Text = "xxx";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(0, 219);
            this.lblType.Margin = new System.Windows.Forms.Padding(0);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblType.Size = new System.Drawing.Size(50, 10);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "xxx";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DarkFader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.colorSlider);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DarkFader";
            this.Size = new System.Drawing.Size(50, 230);
            this.Load += new System.EventHandler(this.DarkFader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorSlider.ColorSlider colorSlider;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblType;
    }
}

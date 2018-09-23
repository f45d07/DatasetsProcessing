namespace DatasetsProcessing
{
    partial class OverlayWindow
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
            this.BoxImg = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.BoxMask = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMask)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxImg
            // 
            this.BoxImg.Location = new System.Drawing.Point(13, 13);
            this.BoxImg.Name = "BoxImg";
            this.BoxImg.Size = new System.Drawing.Size(256, 256);
            this.BoxImg.TabIndex = 0;
            this.BoxImg.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(13, 276);
            this.trackBar.Maximum = 255;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(256, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 200;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // BoxMask
            // 
            this.BoxMask.BackColor = System.Drawing.Color.Transparent;
            this.BoxMask.Location = new System.Drawing.Point(13, 13);
            this.BoxMask.Name = "BoxMask";
            this.BoxMask.Size = new System.Drawing.Size(256, 256);
            this.BoxMask.TabIndex = 2;
            this.BoxMask.TabStop = false;
            // 
            // OverlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.BoxMask);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.BoxImg);
            this.Name = "OverlayWindow";
            this.Text = "OverlayWindow";
            ((System.ComponentModel.ISupportInitialize)(this.BoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoxImg;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox BoxMask;
    }
}
namespace DatasetsProcessing
{
    partial class MainWindow
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
            this.BtnSelectDirOrigImgs = new System.Windows.Forms.Button();
            this.BtnSelectDirOrigMasks = new System.Windows.Forms.Button();
            this.BoxImg = new System.Windows.Forms.PictureBox();
            this.BoxMask = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.BtnSelectDirGoodImgs = new System.Windows.Forms.Button();
            this.BtnSelectDirGoodMasks = new System.Windows.Forms.Button();
            this.BtnOverlay = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.LabelProgress = new System.Windows.Forms.Label();
            this.LabelSaveStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMask)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelectDirOrigImgs
            // 
            this.BtnSelectDirOrigImgs.Location = new System.Drawing.Point(17, 16);
            this.BtnSelectDirOrigImgs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSelectDirOrigImgs.Name = "BtnSelectDirOrigImgs";
            this.BtnSelectDirOrigImgs.Size = new System.Drawing.Size(341, 28);
            this.BtnSelectDirOrigImgs.TabIndex = 0;
            this.BtnSelectDirOrigImgs.Text = "Выбрать папку с исходными снимками";
            this.BtnSelectDirOrigImgs.UseVisualStyleBackColor = true;
            this.BtnSelectDirOrigImgs.Click += new System.EventHandler(this.BtnSelectDirOrigImgs_Click);
            // 
            // BtnSelectDirOrigMasks
            // 
            this.BtnSelectDirOrigMasks.Location = new System.Drawing.Point(368, 15);
            this.BtnSelectDirOrigMasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSelectDirOrigMasks.Name = "BtnSelectDirOrigMasks";
            this.BtnSelectDirOrigMasks.Size = new System.Drawing.Size(341, 28);
            this.BtnSelectDirOrigMasks.TabIndex = 1;
            this.BtnSelectDirOrigMasks.Text = "Выбрать папку с исходными масками";
            this.BtnSelectDirOrigMasks.UseVisualStyleBackColor = true;
            this.BtnSelectDirOrigMasks.Click += new System.EventHandler(this.BtnSelectDirOrigMasks_Click);
            // 
            // BoxImg
            // 
            this.BoxImg.Location = new System.Drawing.Point(17, 53);
            this.BoxImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxImg.Name = "BoxImg";
            this.BoxImg.Size = new System.Drawing.Size(341, 315);
            this.BoxImg.TabIndex = 2;
            this.BoxImg.TabStop = false;
            // 
            // BoxMask
            // 
            this.BoxMask.Location = new System.Drawing.Point(368, 53);
            this.BoxMask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxMask.Name = "BoxMask";
            this.BoxMask.Size = new System.Drawing.Size(341, 315);
            this.BoxMask.TabIndex = 3;
            this.BoxMask.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(719, 15);
            this.BtnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(100, 28);
            this.BtnLoad.TabIndex = 4;
            this.BtnLoad.Text = "Загрузить";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 416);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(692, 16);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // BtnSelectDirGoodImgs
            // 
            this.BtnSelectDirGoodImgs.Location = new System.Drawing.Point(17, 377);
            this.BtnSelectDirGoodImgs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSelectDirGoodImgs.Name = "BtnSelectDirGoodImgs";
            this.BtnSelectDirGoodImgs.Size = new System.Drawing.Size(341, 28);
            this.BtnSelectDirGoodImgs.TabIndex = 6;
            this.BtnSelectDirGoodImgs.Text = "Выбрать папку для готовых снимков";
            this.BtnSelectDirGoodImgs.UseVisualStyleBackColor = true;
            this.BtnSelectDirGoodImgs.Click += new System.EventHandler(this.BtnSelectDirGoodImgs_Click);
            // 
            // BtnSelectDirGoodMasks
            // 
            this.BtnSelectDirGoodMasks.Location = new System.Drawing.Point(368, 377);
            this.BtnSelectDirGoodMasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSelectDirGoodMasks.Name = "BtnSelectDirGoodMasks";
            this.BtnSelectDirGoodMasks.Size = new System.Drawing.Size(341, 28);
            this.BtnSelectDirGoodMasks.TabIndex = 7;
            this.BtnSelectDirGoodMasks.Text = "Выбрать папку для готовых масок";
            this.BtnSelectDirGoodMasks.UseVisualStyleBackColor = true;
            this.BtnSelectDirGoodMasks.Click += new System.EventHandler(this.BtnSelectDirGoodMasks_Click);
            // 
            // BtnOverlay
            // 
            this.BtnOverlay.Enabled = false;
            this.BtnOverlay.Location = new System.Drawing.Point(719, 53);
            this.BtnOverlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOverlay.Name = "BtnOverlay";
            this.BtnOverlay.Size = new System.Drawing.Size(100, 28);
            this.BtnOverlay.TabIndex = 8;
            this.BtnOverlay.Text = "Наложение";
            this.BtnOverlay.UseVisualStyleBackColor = true;
            this.BtnOverlay.Click += new System.EventHandler(this.BtnOverlay_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(719, 338);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 28);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "OK";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Enabled = false;
            this.BtnPrev.Location = new System.Drawing.Point(719, 303);
            this.BtnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(47, 28);
            this.BtnPrev.TabIndex = 10;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Enabled = false;
            this.BtnNext.Location = new System.Drawing.Point(772, 303);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(47, 28);
            this.BtnNext.TabIndex = 11;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(719, 375);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(100, 28);
            this.BtnSettings.TabIndex = 12;
            this.BtnSettings.Text = "Настройки";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(719, 402);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(100, 28);
            this.BtnHelp.TabIndex = 13;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // LabelProgress
            // 
            this.LabelProgress.AutoSize = true;
            this.LabelProgress.Location = new System.Drawing.Point(719, 90);
            this.LabelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(0, 17);
            this.LabelProgress.TabIndex = 14;
            // 
            // LabelSaveStatus
            // 
            this.LabelSaveStatus.AutoSize = true;
            this.LabelSaveStatus.Location = new System.Drawing.Point(723, 114);
            this.LabelSaveStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSaveStatus.Name = "LabelSaveStatus";
            this.LabelSaveStatus.Size = new System.Drawing.Size(0, 17);
            this.LabelSaveStatus.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 447);
            this.Controls.Add(this.LabelSaveStatus);
            this.Controls.Add(this.LabelProgress);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnOverlay);
            this.Controls.Add(this.BtnSelectDirGoodMasks);
            this.Controls.Add(this.BtnSelectDirGoodImgs);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BoxMask);
            this.Controls.Add(this.BoxImg);
            this.Controls.Add(this.BtnSelectDirOrigMasks);
            this.Controls.Add(this.BtnSelectDirOrigImgs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "DatasetsProcessing";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectDirOrigImgs;
        private System.Windows.Forms.Button BtnSelectDirOrigMasks;
        private System.Windows.Forms.PictureBox BoxImg;
        private System.Windows.Forms.PictureBox BoxMask;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button BtnSelectDirGoodImgs;
        private System.Windows.Forms.Button BtnSelectDirGoodMasks;
        private System.Windows.Forms.Button BtnOverlay;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Label LabelProgress;
        private System.Windows.Forms.Label LabelSaveStatus;
    }
}
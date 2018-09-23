namespace DatasetsProcessing
{
    partial class SettingsWindow
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
            this.RadioNum = new System.Windows.Forms.RadioButton();
            this.RadioOrig = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxPath = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioNum
            // 
            this.RadioNum.AutoSize = true;
            this.RadioNum.Location = new System.Drawing.Point(6, 19);
            this.RadioNum.Name = "RadioNum";
            this.RadioNum.Size = new System.Drawing.Size(124, 17);
            this.RadioNum.TabIndex = 1;
            this.RadioNum.TabStop = true;
            this.RadioNum.Text = "Порядковый номер";
            this.RadioNum.UseVisualStyleBackColor = true;
            // 
            // RadioOrig
            // 
            this.RadioOrig.AutoSize = true;
            this.RadioOrig.Location = new System.Drawing.Point(6, 42);
            this.RadioOrig.Name = "RadioOrig";
            this.RadioOrig.Size = new System.Drawing.Size(98, 17);
            this.RadioOrig.TabIndex = 2;
            this.RadioOrig.TabStop = true;
            this.RadioOrig.Text = "Оригинальное";
            this.RadioOrig.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioNum);
            this.groupBox1.Controls.Add(this.RadioOrig);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя файла";
            // 
            // CheckBoxPath
            // 
            this.CheckBoxPath.AutoSize = true;
            this.CheckBoxPath.Location = new System.Drawing.Point(18, 90);
            this.CheckBoxPath.Name = "CheckBoxPath";
            this.CheckBoxPath.Size = new System.Drawing.Size(104, 17);
            this.CheckBoxPath.TabIndex = 4;
            this.CheckBoxPath.Text = "Сохранять путь";
            this.CheckBoxPath.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 125);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(200, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить настройки";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 161);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CheckBoxPath);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsWindow";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioNum;
        private System.Windows.Forms.RadioButton RadioOrig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBoxPath;
        private System.Windows.Forms.Button Save;
    }
}
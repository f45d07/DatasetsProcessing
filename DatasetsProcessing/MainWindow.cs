using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetsProcessing
{
    public partial class MainWindow : Form
    {
        private Processing processing;
        private OverlayWindow overlay;
        private SettingsWindow settingsWindow;
        private Settings settings;

        public MainWindow()
        {
            processing = new Processing();
            settings = new Settings();
            InitializeComponent();
            overlay = null;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                this.BtnPrev_Click(null, null);
                return true;
            }
            if (keyData == Keys.Up)
            {
                this.BtnOverlay_Click(null, null);
                return true;
            }
            if (keyData == Keys.Down)
            {
                this.BtnSave_Click(null, null);
                return true;
            }
            if (keyData == Keys.Right)
            {
                this.BtnNext_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private string SelectFolder(string Description = "")
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            Dialog.Description = Description;
            if (this.processing.PathToOrigImgs != null)
                Dialog.SelectedPath = this.processing.PathToOrigImgs;

            if (DialogResult.OK == Dialog.ShowDialog())
                return Dialog.SelectedPath;
            return null;
        }

        private void BtnSelectDirOrigImgs_Click(object sender, EventArgs e)
        {
            this.processing.PathToOrigImgs = SelectFolder();
        }

        private void BtnSelectDirOrigMasks_Click(object sender, EventArgs e)
        {
            this.processing.PathToOrigMasks = SelectFolder();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.processing.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            BtnOverlay.Enabled = true;
            BtnPrev.Enabled = true;
            BtnNext.Enabled = true;
            BtnSave.Enabled = true;

            progressBar.Maximum = this.processing.GetCountImages();

            BoxImg.Load(this.processing.GetImagePath());
            BoxMask.Load(this.processing.GetMaskPath());
        }

        private void BtnSelectDirGoodImgs_Click(object sender, EventArgs e)
        {
            this.processing.PathToGoodImgs = SelectFolder();
        }

        private void BtnSelectDirGoodMasks_Click(object sender, EventArgs e)
        {
            this.processing.PathToGoodMasks = SelectFolder();
        }

        private void BtnOverlay_Click(object sender, EventArgs e)
        {
            overlay = new OverlayWindow(this.processing.GetImagePath(), this.processing.GetMaskPath());
            overlay.Show();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                this.processing.Prev();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            BoxImg.Load(this.processing.GetImagePath());
            BoxMask.Load(this.processing.GetMaskPath());

            this.UpdateProgressBar();
            this.UpdateOverlay();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.processing.Next();
                BoxImg.Load(this.processing.GetImagePath());
                BoxMask.Load(this.processing.GetMaskPath());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }            

            this.UpdateProgressBar();
            this.UpdateOverlay();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.processing.SaveCurrent(settings);
            BtnNext_Click(null, null);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (settingsWindow == null) {
                settingsWindow = new SettingsWindow(settings);
            }
            if (settingsWindow.IsDisposed)
            {
                settingsWindow = new SettingsWindow(settings);
            }
            settingsWindow.FormClosed += new FormClosedEventHandler(SettingsWindow_Closed);
            settingsWindow.Show();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        private void UpdateSaveStatus()
        {
            LabelSaveStatus.Text = this.processing.IsCurrentSaved() ? "Сохранено" : "Не сохранено";
        }

        private void UpdateProgressLabel()
        {
            LabelProgress.Text = this.processing.GetNumCurrentImage() + " / " + this.processing.GetCountImages();
        }

        private void UpdateProgressBar()
        {
            progressBar.Value = this.processing.GetNumCurrentImage();

            UpdateSaveStatus();
            UpdateProgressLabel();
        }

        private void UpdateOverlay()
        {
           if(this.overlay != null)
               this.overlay.Update(this.processing.GetImagePath(), this.processing.GetMaskPath());
        }

        private void SettingsWindow_Closed(object sender, FormClosedEventArgs e)
        {
            settings.Save(settingsWindow.IsCheckBoxPathChecked(), settingsWindow.IsRadioOrigChecked());
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

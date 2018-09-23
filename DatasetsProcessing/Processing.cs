using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

using System.Windows.Forms;


namespace DatasetsProcessing
{
    class Processing
    {
        //private string _PathToOrigImgs;
        //private string _PathToOrigMasks;
        //private string _PathToGoodImgs;
        //private string _PathToGoodMasks;

        public string PathToOrigImgs { get; set; }
        public string PathToOrigMasks { get; set; }
        public string PathToGoodImgs { get; set; }
        public string PathToGoodMasks { get; set; }
        private List<Image> Images;
        private int CurrentImage;
        private int CountSave;

        public Processing()
        {
            Images = new List<Image>();
            CurrentImage = 0;
            CountSave = 0;
        }

        private void GetImagesFromDir(string path)
        {
            string[] images = Directory.GetFiles(path);
            foreach (string image in images)
                AddImage(image);

            string[] SubDir = Directory.GetDirectories(path);
            foreach (string Dir in SubDir)
                GetImagesFromDir(Dir);
        }

        private void AddImage(string PathToImg)
        {
            if (!(PathToImg.EndsWith(".png") | PathToImg.EndsWith(".jpg"))) return;
            string SubPath = PathToImg.Replace(this.PathToOrigImgs, "");
            Images.Add(new Image { Saved = false, SubPath = SubPath});
        }

        public string GetImagePath(int index)
        {
            return PathToOrigImgs+"/"+Images[index].SubPath;
        }

        public string GetMaskPath(int index)
        {
            return this.PathToOrigMasks + "/" + this.Images[index].SubPath;
        }

        public string GetImagePath()
        {
            if (this.CurrentImage > Images.Count)
                return null;
            return PathToOrigImgs + "/" + Images[this.CurrentImage].SubPath;
        }

        public string GetMaskPath()
        {
            return this.PathToOrigMasks + "/" + this.Images[this.CurrentImage].SubPath;
        }

        public void Next()
        {
            if (this.CurrentImage == this.Images.Count - 1) throw new Exception("Достигнут конец!");
            this.CurrentImage++;
        }

        public void Prev()
        {
            if (this.CurrentImage == 0) throw new Exception("Достигнуто начало!");
            this.CurrentImage--;
        }

        public int GetNumCurrentImage()
        {
            return this.CurrentImage;
        }

        public int GetCountImages()
        {
            return this.Images.Count;
        }

        public bool IsCurrentSaved()
        {
            return this.Images[this.GetNumCurrentImage()].Saved;
        }

        public void SaveCurrent(Settings settings)
        {
            if (!IsCurrentSaved())
            {
                string path = "";
                if (settings.OriginalPath())
                {
                    path = Path.GetDirectoryName(this.Images[this.GetNumCurrentImage()].SubPath);
                    if (!Directory.Exists(this.PathToGoodImgs + "\\" + path))
                        Directory.CreateDirectory(this.PathToGoodImgs + "\\" + path);
                    if (!Directory.Exists(this.PathToGoodMasks + "\\" + path))
                        Directory.CreateDirectory(this.PathToGoodMasks + "\\" + path);
                }

                string filename;
                if (settings.OriginalName())
                    filename = Path.GetFileName(this.Images[this.GetNumCurrentImage()].SubPath);
                else
                    filename = ++this.CountSave + Path.GetExtension(this.Images[this.GetNumCurrentImage()].SubPath);

                System.IO.File.Copy(this.PathToOrigImgs + "\\" + this.Images[this.GetNumCurrentImage()].SubPath, this.PathToGoodImgs + "\\" + path + "\\" + filename, true);
                System.IO.File.Copy(this.PathToOrigMasks + "\\" + this.Images[this.GetNumCurrentImage()].SubPath, this.PathToGoodMasks + "\\" + path + "\\" + filename, true);
                this.Images[this.GetNumCurrentImage()] = new Image() { SubPath = this.Images[this.GetNumCurrentImage()].SubPath, Saved = true };
            }
        }

        public void Start()
        {
            if (!Directory.Exists(PathToOrigImgs)) throw new Exception("PathToOrigImgs not found");
            if (!Directory.Exists(PathToOrigMasks)) throw new Exception("PathToOrigMasks not found");
            if (!Directory.Exists(PathToGoodImgs)) throw new Exception("PathToGoodImgs not found");
            if (!Directory.Exists(PathToGoodMasks)) throw new Exception("PathToGoodMasks not found");

            GetImagesFromDir(this.PathToOrigImgs);
        }
    }

}

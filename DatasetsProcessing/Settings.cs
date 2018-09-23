using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetsProcessing
{
    public class Settings
    {
        private bool SaveOriginalPath;
        private bool SaveOriginalName;

        public Settings()
        {
            SaveOriginalPath = true;
            SaveOriginalName = true;
        }

        public void Save(bool saveOriginalPath, bool saveOriginalName)
        {
            this.SaveOriginalPath = saveOriginalPath;
            this.SaveOriginalName = saveOriginalName;
        }

        public bool OriginalPath()
        {
            return SaveOriginalPath;
        }

        public bool OriginalName()
        {
            return SaveOriginalName;
        }
    }
}

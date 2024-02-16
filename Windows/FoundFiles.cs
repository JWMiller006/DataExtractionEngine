using MillerInc.UI.OutputFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataExtractionEngine.Windows
{
    public partial class FoundFiles : Form
    {
        public FoundFiles()
        {
            InitializeComponent();
            this.pathLabel.Text = $@"Root Path: {GlobalVars.RootDir}";
            this.files = GetMatchingFiles(GlobalVars.RootDir, GlobalVars.SearchPattern);
            //Output.WriteLine(Application.StartupPath + "\\output.txt", MillerInc.Convert.Lists.
            //ListToString.ListString(files, ",\n", "\n\n") + "\nCount: " + files.Count() + "\nRoot Path: " + 
            //GlobalVars.RootDir); 
            this.UpdateFileDisplay(this.files);
        }

        private List<string> files = new();

        public void UpdateFileDisplay(List<string> files)
        {
            List<string> fileNames = new();
            this.AllMatchinFiles.Items.Clear();
            int count = 0;
            foreach (string file in files)
            {
                this.AllMatchinFiles.Items.Add(file.Replace(GlobalVars.RootDir, ""));
                this.AllMatchinFiles.SetItemChecked(count, true);
                count++;
            }

        }

        public static List<string> GetMatchingFiles(string dir, string pattern)
        {
            List<string> outputList = new();
            if (dir != "" && dir != null)
            {
                foreach (string direc in Directory.GetDirectories(dir))
                {
                    outputList.AddRange(GetMatchingFiles(direc, pattern));
                }

                outputList.AddRange(Directory.GetFiles(dir, pattern));
            }
            return outputList;
        }

        private List<string> GetCheckedItems()
        {
            List<string> items = [];

            foreach (int index in this.AllMatchinFiles.CheckedIndices)
            {
                items.Add(this.files[index]);
            }

            return items;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            GlobalVars.GenerationFiles = GetCheckedItems();
            GlobalVars.TrainNetworkWindow = true;
            this.Dispose();
        }

        private void GetData_Click(object sender, EventArgs e)
        {
            GlobalVars.GenerationFiles = GetCheckedItems();
            GlobalVars.OpenDataViewer = true;
        }

        private void trackingExtract_Click(object sender, EventArgs e)
        {
            GlobalVars.GenerationFiles = GetCheckedItems();
            GlobalVars.OpenTracker = true;
        }
    }
}

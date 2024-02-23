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
    public partial class TrackingData : Form
    {
        public TrackingData()
        {
            InitializeComponent();
        }

        public TrackingData(string[] lines)
        {
            InitializeComponent();
            this.textOutput.Lines = lines;
        }

        string fileName = "";
        
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
                SaveFile();
        }

        private void saveTextDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFile(); 
        }

        private void SaveFile()
        {
            if (fileName == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    File.WriteAllLines(fileName, this.textOutput.Lines);
                }
            }
            else File.WriteAllLines(fileName, this.textOutput.Lines);
        }
    }
}

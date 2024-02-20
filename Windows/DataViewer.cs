using DataExtractionEngine.Backend;
using NeuralNetwork.Genetic;
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
    public partial class DataViewer : Form
    {
        private int childFormNumber = 0;
        private List<string> GenerationFiles { get; set; } = new();

        public DataViewer()
        {
            InitializeComponent();
        }

        public DataViewer(List<string> generationFiles)
        {
            InitializeComponent();
            this.GenerationFiles = generationFiles;
            SetupTextDisplay();
        }

        public DataViewer(List<string> generatedFiles, bool tracking)
        {
            if (tracking)
            {
                InitializeComponent();
                this.GenerationFiles = generatedFiles;
                SetupTextDisplayPart2();
            }
        }

        private void SetupTextDisplayPart2()
        {
            this.textOutput.Lines = [];
            /* Lines format 
             * File Name [15] Lowest Frames [15]   Average Fitness[20] Worst Fitness [20]  Best Frame [20]  
             * gen0000        0.1585666652666666  0.1585666652666666  0.1585666652666666  0.1585666652666666
             */
            string[] lines = new string[2];
            int count = 1;
            lines[0] = "#".PadRight(5) + "File Name".PadRight(40) + "Lowest Frames".PadRight(17) + "Average Frames".PadRight(25) +
                "Most Frames".PadRight(17) + "Generational Frames".PadRight(25) + "Tracking Frames".PadRight(17);
            int maxFrames = -1;
            int minFrames = -1;
            double avgFrames = -1;
            double avgGenerationalFrames = -1;
            double avgTrackingFrames = -1;
            TrackingInstance instance = new(); 
            foreach (string file in this.GenerationFiles)
            {
                instance = new(file);
                if (maxFrames == -1 || maxFrames < instance.GenerationalFrames)
                {
                    maxFrames = instance.GenerationalFrames;
                }
                if (minFrames == -1 || minFrames > instance.GenerationalFrames)
                {
                    minFrames = instance.GenerationalFrames;
                }
                if (avgFrames == -1)
                {
                    avgFrames = instance.TrackingFrames + instance.GenerationalFrames;
                }
                else
                {
                    avgFrames = (avgFrames + instance.TrackingFrames + instance.GenerationalFrames) / 2;
                }
                if (avgGenerationalFrames == -1)
                {
                    avgGenerationalFrames = instance.GenerationalFrames;
                }
                else
                {
                    avgGenerationalFrames = (avgGenerationalFrames + instance.GenerationalFrames) / 2;
                }
                if (avgTrackingFrames == -1)
                {
                    avgTrackingFrames = instance.TrackingFrames;
                }
                else
                {
                    avgTrackingFrames = (avgTrackingFrames + instance.TrackingFrames) / 2;
                }


            }
            lines[count] = count.ToString().PadRight(5) + Path.GetFileName(this.GenerationFiles.First()).PadRight(40) + minFrames.ToString().PadRight(17) +
                    avgFrames.ToString().PadRight(25) + maxFrames.ToString().PadRight(17) +
                    avgGenerationalFrames.ToString().PadRight(25) + avgTrackingFrames.ToString().PadRight(17);

            this.textOutput.Lines = lines;
            return;
        }
    

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;

            }
        }

        private void SetupTextDisplay()
        {
            this.textOutput.Lines = [];
            /* Lines format 
             * File Name [15] Best Fitness [20]   Average Fitness[20] Worst Fitness [20]  Best Frame [20]  
             * gen0000        0.1585666652666666  0.1585666652666666  0.1585666652666666  0.1585666652666666
             */
            string[] lines = new string[this.GenerationFiles.Count + 1];
            int count = 1;
            lines[0] = "#".PadRight(5) + "File Name".PadRight(20) + "Best Fitness".PadRight(30) + "Average Fitness".PadRight(30) +
                "Worst Fitness".PadRight(30) + "Best Frame".PadRight(15) + "Times Found".PadRight(15);
            Generation generation;
            double maxFitness = 0f;
            double minFitness = 0f;
            int frameFoundBest = -1;
            double avgFitness = 0f;
            int timesFound;
            foreach (string file in this.GenerationFiles)
            {
                generation = new(file);
                timesFound = 0;
                foreach (var ind in generation.Individuals)
                {
                    if (ind.Fitness > maxFitness)
                    {
                        maxFitness = ind.Fitness;
                    }
                    if (ind.Fitness < minFitness || minFitness == 0)
                    {
                        minFitness = ind.Fitness;
                    }
                    if (frameFoundBest == -1 && ind.frameFound != -1)
                    {
                        frameFoundBest = ind.frameFound;
                    }
                    if (frameFoundBest > ind.frameFound && ind.frameFound != -1)
                    {
                        frameFoundBest = ind.frameFound;
                    }
                    if (avgFitness == 0f)
                    {
                        avgFitness = ind.Fitness;
                    }
                    else
                    {
                        avgFitness = (avgFitness + ind.Fitness) / 2;
                    }
                    if (ind.Found)
                    {
                        timesFound++;
                    }
                }
                lines[count] = count.ToString().PadRight(5) + Path.GetFileName(file).PadRight(20) + maxFitness.ToString().PadRight(30) +
                    avgFitness.ToString().PadRight(30) + minFitness.ToString().PadRight(30) +
                    frameFoundBest.ToString().PadRight(15) + timesFound.ToString().PadRight(15);
                count++;
            }
            this.textOutput.Lines = lines;
            return;
        }

        string FileName = "";

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileName = saveFileDialog.FileName;
                File.WriteAllLines(FileName, this.textOutput.Lines);
            }

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (FileName == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                    File.WriteAllLines(FileName, this.textOutput.Lines);
                }
            }
            else File.WriteAllLines(FileName, this.textOutput.Lines);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (FileName == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                    File.WriteAllLines(FileName, this.textOutput.Lines);
                }
            }
            else File.WriteAllLines(FileName, this.textOutput.Lines);
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            GlobalVars.OpenNewWindow = true;
            this.Dispose(); 
        }
    }
}

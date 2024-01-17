using MillerInc.UI.OutputFile;

namespace DataExtractionEngine.Windows
{
    partial class LoadingWindow
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
        public void InitializeComponent()
        {
            Output.WriteLine(Application.StartupPath + "\\output.txt", $@"Variable Count :: {GlobalVars.GenerationFiles.Count()}");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingWindow));
            progressOutput = new ProgressBar();
            label1 = new Label();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            progressUpdater = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // progressOutput
            // 
            progressOutput.ForeColor = Color.LightCoral;
            progressOutput.Location = new Point(43, 117);
            progressOutput.Name = "progressOutput";
            progressOutput.Size = new Size(322, 35);
            progressOutput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 94);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 1;
            label1.Text = "Training Neural Network";
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            // 
            // progressUpdater
            // 
            progressUpdater.DoWork += progressUpdater_DoWork;
            // 
            // LoadingWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 241);
            Controls.Add(label1);
            Controls.Add(progressOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadingWindow";
            Text = "Loading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public volatile ProgressBar progressOutput;
        private Label label1;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.ComponentModel.BackgroundWorker progressUpdater;
    }
}
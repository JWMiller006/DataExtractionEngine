namespace DataExtractionEngine
{
    partial class StartupWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupWindow));
            chooseFolderInput = new FolderBrowserDialog();
            pathChosenInput = new TextBox();
            openFolderBrowser = new Button();
            PathLabel = new Label();
            OutputLabel = new Label();
            choseFolderOutputButton = new Button();
            chosenFolderOutput = new TextBox();
            chooseFolderOutput = new FolderBrowserDialog();
            TrainNeuralNetwork = new CheckBox();
            NeuralNetworkPathLabel = new Label();
            OpenNetworkPath = new Button();
            NeuralNetworkPath = new TextBox();
            FileExt = new TextBox();
            fileName = new TextBox();
            fileNameLabel = new Label();
            fileExtLabel = new Label();
            ContinueButton = new Button();
            chooseNetworkFile = new OpenFileDialog();
            tabContoller = new TabControl();
            GenerationTab = new TabPage();
            genDataAnalysisLbl = new Label();
            trackingTab = new TabPage();
            trackDataAnalysisLbl = new Label();
            tabContoller.SuspendLayout();
            GenerationTab.SuspendLayout();
            trackingTab.SuspendLayout();
            SuspendLayout();
            // 
            // chooseFolderInput
            // 
            chooseFolderInput.AddToRecent = false;
            chooseFolderInput.OkRequiresInteraction = true;
            chooseFolderInput.RootFolder = Environment.SpecialFolder.MyDocuments;
            chooseFolderInput.ShowHiddenFiles = true;
            chooseFolderInput.HelpRequest += chooseFolderInput_HelpRequest;
            // 
            // pathChosenInput
            // 
            pathChosenInput.Location = new Point(36, 73);
            pathChosenInput.Margin = new Padding(3, 2, 3, 2);
            pathChosenInput.Name = "pathChosenInput";
            pathChosenInput.Size = new Size(457, 23);
            pathChosenInput.TabIndex = 0;
            // 
            // openFolderBrowser
            // 
            openFolderBrowser.Location = new Point(498, 67);
            openFolderBrowser.Margin = new Padding(3, 2, 3, 2);
            openFolderBrowser.Name = "openFolderBrowser";
            openFolderBrowser.Size = new Size(127, 32);
            openFolderBrowser.TabIndex = 1;
            openFolderBrowser.Text = "Choose Folder";
            openFolderBrowser.UseVisualStyleBackColor = true;
            openFolderBrowser.Click += openFolderBrowser_Click;
            // 
            // PathLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Location = new Point(237, 56);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new Size(59, 15);
            PathLabel.TabIndex = 2;
            PathLabel.Text = "Root Path";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(218, 82);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(72, 15);
            OutputLabel.TabIndex = 5;
            OutputLabel.Text = "Output Path";
            // 
            // choseFolderOutputButton
            // 
            choseFolderOutputButton.Location = new Point(479, 94);
            choseFolderOutputButton.Margin = new Padding(3, 2, 3, 2);
            choseFolderOutputButton.Name = "choseFolderOutputButton";
            choseFolderOutputButton.Size = new Size(127, 32);
            choseFolderOutputButton.TabIndex = 4;
            choseFolderOutputButton.Text = "Choose Folder";
            choseFolderOutputButton.UseVisualStyleBackColor = true;
            choseFolderOutputButton.Click += choseFolderOutputButton_Click;
            // 
            // chosenFolderOutput
            // 
            chosenFolderOutput.Location = new Point(17, 100);
            chosenFolderOutput.Margin = new Padding(3, 2, 3, 2);
            chosenFolderOutput.Name = "chosenFolderOutput";
            chosenFolderOutput.Size = new Size(457, 23);
            chosenFolderOutput.TabIndex = 3;
            // 
            // chooseFolderOutput
            // 
            chooseFolderOutput.AddToRecent = false;
            chooseFolderOutput.OkRequiresInteraction = true;
            chooseFolderOutput.RootFolder = Environment.SpecialFolder.MyDocuments;
            chooseFolderOutput.ShowHiddenFiles = true;
            chooseFolderOutput.HelpRequest += chooseFolderOutput_HelpRequest;
            // 
            // TrainNeuralNetwork
            // 
            TrainNeuralNetwork.AutoSize = true;
            TrainNeuralNetwork.Checked = true;
            TrainNeuralNetwork.CheckState = CheckState.Checked;
            TrainNeuralNetwork.Location = new Point(17, 139);
            TrainNeuralNetwork.Margin = new Padding(3, 2, 3, 2);
            TrainNeuralNetwork.Name = "TrainNeuralNetwork";
            TrainNeuralNetwork.Size = new Size(137, 19);
            TrainNeuralNetwork.TabIndex = 6;
            TrainNeuralNetwork.Text = "Train Neural Network";
            TrainNeuralNetwork.UseVisualStyleBackColor = true;
            TrainNeuralNetwork.CheckedChanged += TrainNeuralNetwork_CheckedChanged;
            // 
            // NeuralNetworkPathLabel
            // 
            NeuralNetworkPathLabel.AutoSize = true;
            NeuralNetworkPathLabel.Location = new Point(189, 144);
            NeuralNetworkPathLabel.Name = "NeuralNetworkPathLabel";
            NeuralNetworkPathLabel.Size = new Size(113, 15);
            NeuralNetworkPathLabel.TabIndex = 9;
            NeuralNetworkPathLabel.Text = "Neual Network Path";
            // 
            // OpenNetworkPath
            // 
            OpenNetworkPath.Location = new Point(479, 155);
            OpenNetworkPath.Margin = new Padding(3, 2, 3, 2);
            OpenNetworkPath.Name = "OpenNetworkPath";
            OpenNetworkPath.Size = new Size(127, 32);
            OpenNetworkPath.TabIndex = 8;
            OpenNetworkPath.Text = "Choose Path";
            OpenNetworkPath.UseVisualStyleBackColor = true;
            OpenNetworkPath.Click += OpenNetworkPath_Click;
            // 
            // NeuralNetworkPath
            // 
            NeuralNetworkPath.Location = new Point(17, 161);
            NeuralNetworkPath.Margin = new Padding(3, 2, 3, 2);
            NeuralNetworkPath.Name = "NeuralNetworkPath";
            NeuralNetworkPath.Size = new Size(457, 23);
            NeuralNetworkPath.TabIndex = 7;
            // 
            // FileExt
            // 
            FileExt.Location = new Point(398, 416);
            FileExt.Margin = new Padding(3, 2, 3, 2);
            FileExt.Name = "FileExt";
            FileExt.Size = new Size(96, 23);
            FileExt.TabIndex = 10;
            FileExt.Text = "json";
            // 
            // fileName
            // 
            fileName.Location = new Point(36, 416);
            fileName.Margin = new Padding(3, 2, 3, 2);
            fileName.Name = "fileName";
            fileName.Size = new Size(357, 23);
            fileName.TabIndex = 11;
            fileName.Text = "%";
            fileName.TextAlign = HorizontalAlignment.Right;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(36, 399);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(311, 15);
            fileNameLabel.TabIndex = 12;
            fileNameLabel.Text = "File Name (w/o extension; use % for number placeholder)";
            // 
            // fileExtLabel
            // 
            fileExtLabel.AutoSize = true;
            fileExtLabel.Location = new Point(398, 399);
            fileExtLabel.Name = "fileExtLabel";
            fileExtLabel.Size = new Size(79, 15);
            fileExtLabel.TabIndex = 13;
            fileExtLabel.Text = "File Extension";
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(498, 407);
            ContinueButton.Margin = new Padding(3, 2, 3, 2);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(127, 32);
            ContinueButton.TabIndex = 14;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // chooseNetworkFile
            // 
            chooseNetworkFile.DefaultExt = "json";
            chooseNetworkFile.FileName = "network";
            chooseNetworkFile.ShowHiddenFiles = true;
            chooseNetworkFile.SupportMultiDottedExtensions = true;
            chooseNetworkFile.FileOk += chooseNetworkFile_FileOk;
            // 
            // tabContoller
            // 
            tabContoller.Controls.Add(GenerationTab);
            tabContoller.Controls.Add(trackingTab);
            tabContoller.Location = new Point(10, 126);
            tabContoller.Name = "tabContoller";
            tabContoller.SelectedIndex = 0;
            tabContoller.Size = new Size(662, 246);
            tabContoller.TabIndex = 15;
            tabContoller.Click += tabContoller_Click;
            // 
            // GenerationTab
            // 
            GenerationTab.Controls.Add(genDataAnalysisLbl);
            GenerationTab.Controls.Add(OutputLabel);
            GenerationTab.Controls.Add(chosenFolderOutput);
            GenerationTab.Controls.Add(choseFolderOutputButton);
            GenerationTab.Controls.Add(TrainNeuralNetwork);
            GenerationTab.Controls.Add(NeuralNetworkPath);
            GenerationTab.Controls.Add(OpenNetworkPath);
            GenerationTab.Controls.Add(NeuralNetworkPathLabel);
            GenerationTab.Location = new Point(4, 24);
            GenerationTab.Name = "GenerationTab";
            GenerationTab.Padding = new Padding(3);
            GenerationTab.Size = new Size(654, 218);
            GenerationTab.TabIndex = 0;
            GenerationTab.Text = "Generational Data Analysis";
            GenerationTab.UseVisualStyleBackColor = true;
            GenerationTab.Click += GenerationTab_Click;
            GenerationTab.MouseEnter += GenerationTab_MouseEnter;
            // 
            // genDataAnalysisLbl
            // 
            genDataAnalysisLbl.AutoSize = true;
            genDataAnalysisLbl.Location = new Point(81, 21);
            genDataAnalysisLbl.Name = "genDataAnalysisLbl";
            genDataAnalysisLbl.Size = new Size(473, 45);
            genDataAnalysisLbl.TabIndex = 10;
            genDataAnalysisLbl.Text = resources.GetString("genDataAnalysisLbl.Text");
            // 
            // trackingTab
            // 
            trackingTab.Controls.Add(trackDataAnalysisLbl);
            trackingTab.Location = new Point(4, 24);
            trackingTab.Name = "trackingTab";
            trackingTab.Padding = new Padding(3);
            trackingTab.Size = new Size(654, 218);
            trackingTab.TabIndex = 1;
            trackingTab.Text = "Tracking Data Analysis";
            trackingTab.UseVisualStyleBackColor = true;
            trackingTab.Click += trackingTab_Click;
            trackingTab.MouseEnter += trackingTab_MouseEnter;
            // 
            // trackDataAnalysisLbl
            // 
            trackDataAnalysisLbl.AutoSize = true;
            trackDataAnalysisLbl.Location = new Point(139, 45);
            trackDataAnalysisLbl.Name = "trackDataAnalysisLbl";
            trackDataAnalysisLbl.Size = new Size(357, 90);
            trackDataAnalysisLbl.TabIndex = 0;
            trackDataAnalysisLbl.Text = resources.GetString("trackDataAnalysisLbl.Text");
            // 
            // StartupWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 511);
            Controls.Add(tabContoller);
            Controls.Add(ContinueButton);
            Controls.Add(fileExtLabel);
            Controls.Add(fileNameLabel);
            Controls.Add(fileName);
            Controls.Add(FileExt);
            Controls.Add(PathLabel);
            Controls.Add(openFolderBrowser);
            Controls.Add(pathChosenInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "StartupWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Specify Parameters";
            tabContoller.ResumeLayout(false);
            GenerationTab.ResumeLayout(false);
            GenerationTab.PerformLayout();
            trackingTab.ResumeLayout(false);
            trackingTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog chooseFolderInput;
        private TextBox pathChosenInput;
        private Button openFolderBrowser;
        private Label PathLabel;
        private Label OutputLabel;
        private Button choseFolderOutputButton;
        private TextBox chosenFolderOutput;
        private FolderBrowserDialog chooseFolderOutput;
        private CheckBox TrainNeuralNetwork;
        private Label NeuralNetworkPathLabel;
        private Button OpenNetworkPath;
        private TextBox NeuralNetworkPath;
        private TextBox FileExt;
        private TextBox fileName;
        private Label fileNameLabel;
        private Label fileExtLabel;
        private Button ContinueButton;
        private OpenFileDialog chooseNetworkFile;
        private TabControl tabContoller;
        private TabPage GenerationTab;
        private TabPage trackingTab;
        private Label genDataAnalysisLbl;
        private Label trackDataAnalysisLbl;
    }
}

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
            pathChosenInput.Location = new Point(12, 97);
            pathChosenInput.Name = "pathChosenInput";
            pathChosenInput.Size = new Size(522, 27);
            pathChosenInput.TabIndex = 0;
            // 
            // openFolderBrowser
            // 
            openFolderBrowser.Location = new Point(540, 89);
            openFolderBrowser.Name = "openFolderBrowser";
            openFolderBrowser.Size = new Size(145, 42);
            openFolderBrowser.TabIndex = 1;
            openFolderBrowser.Text = "Choose Folder";
            openFolderBrowser.UseVisualStyleBackColor = true;
            openFolderBrowser.Click += openFolderBrowser_Click;
            // 
            // PathLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Location = new Point(241, 74);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new Size(73, 20);
            PathLabel.TabIndex = 2;
            PathLabel.Text = "Root Path";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(241, 150);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(87, 20);
            OutputLabel.TabIndex = 5;
            OutputLabel.Text = "Output Path";
            // 
            // choseFolderOutputButton
            // 
            choseFolderOutputButton.Location = new Point(540, 165);
            choseFolderOutputButton.Name = "choseFolderOutputButton";
            choseFolderOutputButton.Size = new Size(145, 42);
            choseFolderOutputButton.TabIndex = 4;
            choseFolderOutputButton.Text = "Choose Folder";
            choseFolderOutputButton.UseVisualStyleBackColor = true;
            choseFolderOutputButton.Click += choseFolderOutputButton_Click;
            // 
            // chosenFolderOutput
            // 
            chosenFolderOutput.Location = new Point(12, 173);
            chosenFolderOutput.Name = "chosenFolderOutput";
            chosenFolderOutput.Size = new Size(522, 27);
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
            TrainNeuralNetwork.Location = new Point(12, 225);
            TrainNeuralNetwork.Name = "TrainNeuralNetwork";
            TrainNeuralNetwork.Size = new Size(171, 24);
            TrainNeuralNetwork.TabIndex = 6;
            TrainNeuralNetwork.Text = "Train Neural Network";
            TrainNeuralNetwork.UseVisualStyleBackColor = true;
            TrainNeuralNetwork.CheckedChanged += TrainNeuralNetwork_CheckedChanged;
            // 
            // NeuralNetworkPathLabel
            // 
            NeuralNetworkPathLabel.AutoSize = true;
            NeuralNetworkPathLabel.Location = new Point(208, 232);
            NeuralNetworkPathLabel.Name = "NeuralNetworkPathLabel";
            NeuralNetworkPathLabel.Size = new Size(140, 20);
            NeuralNetworkPathLabel.TabIndex = 9;
            NeuralNetworkPathLabel.Text = "Neual Network Path";
            // 
            // OpenNetworkPath
            // 
            OpenNetworkPath.Location = new Point(540, 247);
            OpenNetworkPath.Name = "OpenNetworkPath";
            OpenNetworkPath.Size = new Size(145, 42);
            OpenNetworkPath.TabIndex = 8;
            OpenNetworkPath.Text = "Choose Path";
            OpenNetworkPath.UseVisualStyleBackColor = true;
            OpenNetworkPath.Click += OpenNetworkPath_Click;
            // 
            // NeuralNetworkPath
            // 
            NeuralNetworkPath.Location = new Point(12, 255);
            NeuralNetworkPath.Name = "NeuralNetworkPath";
            NeuralNetworkPath.Size = new Size(522, 27);
            NeuralNetworkPath.TabIndex = 7;
            // 
            // FileExt
            // 
            FileExt.Location = new Point(425, 340);
            FileExt.Name = "FileExt";
            FileExt.Size = new Size(109, 27);
            FileExt.TabIndex = 10;
            FileExt.Text = "json";
            // 
            // fileName
            // 
            fileName.Location = new Point(12, 340);
            fileName.Name = "fileName";
            fileName.Size = new Size(407, 27);
            fileName.TabIndex = 11;
            fileName.Text = "gen%%%";
            fileName.TextAlign = HorizontalAlignment.Right;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(12, 317);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(389, 20);
            fileNameLabel.TabIndex = 12;
            fileNameLabel.Text = "File Name (w/o extension; use % for number placeholder)";
            // 
            // fileExtLabel
            // 
            fileExtLabel.AutoSize = true;
            fileExtLabel.Location = new Point(425, 317);
            fileExtLabel.Name = "fileExtLabel";
            fileExtLabel.Size = new Size(99, 20);
            fileExtLabel.TabIndex = 13;
            fileExtLabel.Text = "File Extension";
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(540, 328);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(145, 43);
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
            // StartupWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(ContinueButton);
            Controls.Add(fileExtLabel);
            Controls.Add(fileNameLabel);
            Controls.Add(fileName);
            Controls.Add(FileExt);
            Controls.Add(NeuralNetworkPathLabel);
            Controls.Add(OpenNetworkPath);
            Controls.Add(NeuralNetworkPath);
            Controls.Add(TrainNeuralNetwork);
            Controls.Add(OutputLabel);
            Controls.Add(choseFolderOutputButton);
            Controls.Add(chosenFolderOutput);
            Controls.Add(PathLabel);
            Controls.Add(openFolderBrowser);
            Controls.Add(pathChosenInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartupWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Specify Parameters";
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
    }
}

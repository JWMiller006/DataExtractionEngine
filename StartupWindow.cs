namespace DataExtractionEngine
{
    public partial class StartupWindow : Form
    {
        public StartupWindow()
        {
            InitializeComponent();
            this.TrainNeuralNetwork.Checked = false; 
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            if (!this.TrainNeuralNetwork.Checked)
            {
                this.NeuralNetworkPath.Hide();
                this.NeuralNetworkPathLabel.Hide();
                this.OpenNetworkPath.Hide();
            }
            else
            {
                this.NeuralNetworkPath.Show();
                this.NeuralNetworkPathLabel.Show();
                this.OpenNetworkPath.Show();
            }
        }

        private void openFolderBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = this.chooseFolderInput.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pathChosenInput.Text = this.chooseFolderInput.SelectedPath;
            }
        }

        private void choseFolderOutputButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.chooseFolderOutput.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.chosenFolderOutput.Text = this.chooseFolderOutput.SelectedPath;
            }
        }

        private void OpenNetworkPath_Click(object sender, EventArgs e)
        {
            this.chooseNetworkFile.ShowDialog();
        }

        private void chooseFolderInput_HelpRequest(object sender, EventArgs e)
        {

        }

        private void chooseFolderOutput_HelpRequest(object sender, EventArgs e)
        {

        }

        private void chooseNetworkFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.NeuralNetworkPath.Text = chooseNetworkFile.FileName; 
        }

        private void TrainNeuralNetwork_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            GlobalVars.RootDir = this.pathChosenInput.Text;
            GlobalVars.OutputPath = this.chosenFolderOutput.Text;
            if (this.TrainNeuralNetwork.Checked)
            {
                GlobalVars.NeuralNetworkPath = this.NeuralNetworkPath.Text;
                GlobalVars.NeuralNetwork = new(GlobalVars.NeuralNetworkPath);
            }
            GlobalVars.TrainNetwork = this.TrainNeuralNetwork.Checked; 
            GlobalVars.SearchPattern = this.fileName.Text.Replace('%', '*') + "." + this.FileExt.Text;
            GlobalVars.OpenNewWindow = true;   
        }
    }
}

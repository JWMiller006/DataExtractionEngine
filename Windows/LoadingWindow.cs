using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataExtractionEngine.Processes;
using MillerInc.UI.OutputFile;
using Network = MillerInc.ML.NeuralNetwork.NeuralNet;

namespace DataExtractionEngine.Windows
{
    public partial class LoadingWindow : Form
    {
        public LoadingWindow()
        {
            InitializeComponent();

            //Output.WriteLine(Application.StartupPath + "\\output.txt", $"Starting first async worker");

            this.backgroundWorker.RunWorkerAsync();

            //Output.WriteLine(Application.StartupPath + "\\output.txt", $"Starting second async worker

            this.progressUpdater.RunWorkerAsync();

            //Output.WriteLine(Application.StartupPath + "\\output.txt", $"Both are started");

        }

        public LoadingWindow(List<string> gens, Network network)
        {
            InitializeComponent();

            this.network = network;

            this.gensString = gens; 

            this.backgroundWorker.RunWorkerAsync();
            this.progressUpdater.RunWorkerAsync(); 
        }

        List<string> gensString = [];

        TrainNetwork networkTrainer = new();

        Network network = GlobalVars.Builder.Build();

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Output.WriteLine(Application.StartupPath + "\\output.txt", $"First thread started");

            networkTrainer.Setup(this.gensString, this.network); 

            networkTrainer.TrainNetworkCPU();

            Output.WriteLine(Application.StartupPath + "\\output.txt", $"First thread finished, {GlobalVars.GenerationFiles.Count}");
        }

        private async void progressUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            //Output.WriteLine(Application.StartupPath + "\\output.txt", $"Second thread started");
            Thread outputThread = new(async() =>
            {
                while (!this.IsDisposed)
                {
                    //Output.WriteLine(Application.StartupPath + "\\output.ex.txt", networkTrainer.Data + " :: " + networkTrainer.Status);
                    await Task.Delay(1000); 
                }
            });
            outputThread.SetApartmentState(ApartmentState.STA);
            outputThread.Start(); 
            
            int count = 0;
            string heading;
            decimal prev = 0; 
            while (!this.IsDisposed)
            {
                heading = "Loading";
                for (int i = 0; i < count; i++) heading += ".";
                //this.Text = heading; 
                if ((decimal)(networkTrainer.Status * 100f) > 0)
                {
                    heading += $" - {(decimal)(networkTrainer.Status * 100f)}%";
                    prev = (decimal)(networkTrainer.Status * 100f); 
                }
                else heading += $" - {prev}%";
                try
                {
                    GlobalVars.Loader.progressOutput.Invoke((System.Windows.Forms.MethodInvoker)delegate
                    {
                        if (networkTrainer.Status > 0)
                        {
                            GlobalVars.Loader.progressOutput.Value = (int)(networkTrainer.Status * 100f);
                        }
                    });
                    if (networkTrainer.Status > 0) {
                        GlobalVars.Loader.Invoke((System.Windows.Forms.MethodInvoker)delegate
                        {

                            GlobalVars.Loader.Text = heading;
                        });
                    }
                }
                catch
                {

                }
                if (count == 3) count = 0;
                count++;
                await Task.Delay(250);
            }
        }
    }
}

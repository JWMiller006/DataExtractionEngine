using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MillerInc.UI.OutputFile;
using NeuralNetwork.Genetic;
using NeuralNetwork.Genetic.DataControls;
using Network = MillerInc.ML.NeuralNetwork.NeuralNet;

namespace DataExtractionEngine.Processes
{
    public class TrainNetwork
    {
        public TrainNetwork()
        {

        }

        public TrainNetwork(List<string> generationFiles)
        {
            this.Setup(generationFiles, GlobalVars.NeuralNetwork);
        }

        public TrainNetwork(bool trainNow)
        {
            if (trainNow)
            {
                this.TrainNetworkCPU();
            }
        }
        
        public void Setup(List<string> generationDataFiles, Network network)
        {
            this.Data = "Setup";
            this.IsTraining = true;
            Thread trainingThread = new(() =>
            {
                Data += "; Trainer Thread :: Started";
                Output.WriteLine(Application.StartupPath + "\\output0.txt", $"Training thread started");
                Output.WriteLine(Application.StartupPath + "\\count.txt", $"Count: {generationDataFiles.Count}");
                float[][] inputValues = new float[1][];
                float[][] outputValues = new float[1][];
                float total = generationDataFiles.Count() * 3000f * 20f;
                Data += "; Total :: " + total;
                float iterationCount = 0;
                Data += "; Status :: 0";
                string temp;

                Parallel.ForEach(generationDataFiles, gens =>
                {
                    //Output.WriteLine(Application.StartupPath + "\\output1.txt", $@"file name: {gens}");
                    Data += "gen";

                    Generation generation = new(gens);

                    Parallel.For(0, generation.InputValues.Count(), (i) =>
                    {
                        //Output.WriteLine(Application.StartupPath + "\\output2.txt", $"\tIndividual: {i}");
                        Parallel.For(0, generation.InputValues[i].Count(), (j) =>
                        {
                            //Output.WriteLine(Application.StartupPath + "\\output3.txt", $"\t\tFrame: {j}");
                            temp = iterationCount.ToString();
                            iterationCount++;
                            Data.Replace("; Status :: " + temp, "; Status :: " + iterationCount.ToString());
                            inputValues[0] = generation.InputValues[i][j];
                            outputValues[0] = generation.OutputValues[i][j];
                            GlobalVars.NeuralNetwork.Learn(inputValues, outputValues);
                            this.Status = (float)(iterationCount / total);
                        });
                    });


                    /*
                     *                    // iterate over each individual 
                     *                                       for (int i = 0; i < generation.InputValues.Count(); i++)
                     *                                                          {
                     *                                                                                 Output.WriteLine(Application.StartupPath + "\\output2.txt", $"\tIndividual: {i}");
                     *                                                                                                        
                     *                                                                                                                               // Iterate over each frame 
                     *                                                                                                                                                      for (int j = 0; j < generation.InputValues[i].Count(); j++)
                     *                                                                                                                                                                             {
                     *                                                                                                                                                                                                        Output.WriteLine(Application.StartupPath + "\\output3.txt", $"\t\tFrame: {j}");
                     *                                                                                                                                                                                                                                   temp = iterationCount.ToString(); 
                     *                                                                                                                                                                                                                                                              iterationCount++;
                     *                                                                                                                                                                                                                                                                                         Data.Replace( "; Status :: " + temp, "; Status :: " + iterationCount.ToString());
                     *                                                                                                                                                                                                                                                                                                                    inputValues[0] = generation.InputValues[i][j];
                     *                                                                                                                                                                                                                                                                                                                                               outputValues[0] = generation.OutputValues[i][j];
                     *                                                                                                                                                                                                                                                                                                                                                                          GlobalVars.NeuralNetwork.Train(inputValues, outputValues);
                     *                                                                                                                                                                                                                                                                                                                                                                                                     this.Status = (float)(iterationCount / total);
                     *                                                                                                                                                                                                                                                                                                                                                                                                                            }
                     *                                                                                                                                                                                                                                                                                                                                                                                                                                                   GlobalVars.NeuralNetwork.SaveTo(Application.StartupPath + "\\trained network.json");
                     *                                                                                                                                                                                                                                                                                                                                                                                                                                                                      }*/
                });
                /*
                foreach (var gen in generationDataFiles)
                {
                    Output.WriteLine(Application.StartupPath + "\\output1.txt", $@"file name: {gen}");
                    Data += "gen";

                    Generation generation = new(gen);

                    Parallel.For(0, generation.InputValues.Count(), (i) =>
                    {
                        //Output.WriteLine(Application.StartupPath + "\\output2.txt", $"\tIndividual: {i}");
                        Parallel.For(0, generation.InputValues[i].Count(), (j) =>
                        {
                            //Output.WriteLine(Application.StartupPath + "\\output3.txt", $"\t\tFrame: {j}");
                            temp = iterationCount.ToString();
                            iterationCount++;
                            Data.Replace("; Status :: " + temp, "; Status :: " + iterationCount.ToString());
                            inputValues[0] = generation.InputValues[i][j];
                            outputValues[0] = generation.OutputValues[i][j];
                            GlobalVars.NeuralNetwork.Train(inputValues, outputValues);
                            this.Status = (float)(iterationCount / total);
                        });
                    });

                    GlobalVars.NeuralNetwork.SaveTo(Application.StartupPath + "\\trained network.json");

                    /*
                    // iterate over each individual 
                    for (int i = 0; i < generation.InputValues.Count(); i++)
                    {
                        Output.WriteLine(Application.StartupPath + "\\output2.txt", $"\tIndividual: {i}");
                        
                        // Iterate over each frame 
                        for (int j = 0; j < generation.InputValues[i].Count(); j++)
                        {
                            Output.WriteLine(Application.StartupPath + "\\output3.txt", $"\t\tFrame: {j}");
                            temp = iterationCount.ToString(); 
                            iterationCount++;
                            Data.Replace( "; Status :: " + temp, "; Status :: " + iterationCount.ToString());
                            inputValues[0] = generation.InputValues[i][j];
                            outputValues[0] = generation.OutputValues[i][j];
                            GlobalVars.NeuralNetwork.Train(inputValues, outputValues);
                            this.Status = (float)(iterationCount / total);
                        }
                        GlobalVars.NeuralNetwork.SaveTo(Application.StartupPath + "\\trained network.json");
                    }
                }*/

                GlobalVars.NeuralNetwork.SaveTo(Application.StartupPath + "\\trained network.json");
                Data.Replace("Started", "Finished");
            });
            trainingThread.SetApartmentState(ApartmentState.STA);

            this.TrainingThread = trainingThread;

            this.Data += " :: Complete";
        }


        [Obsolete("Not able to use GPU currently, use " + "TrainNetwork.TrainNetworkCPU" + " instead")]
        public void TrainNetworkGPU()
        {
            throw new NotImplementedException();
        }

        public void TrainNetworkCPU()
        {
            Output.WriteLine(Application.StartupPath + "\\output.txt", $"Starting up training");
            this.TrainingThread.Start();
        }

        public Thread TrainingThread { get; set; } = new Thread(() => { });

        public volatile bool IsTraining = false;

        public volatile float Status = 0.0f;

        public volatile string Data = "";
    }
}

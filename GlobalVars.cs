using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network = MillerInc.ML.NeuralNetwork.NeuralNet;
using MillerInc.UI.OutputFile;
using DataExtractionEngine.Windows;
using MillerInc.ML.NeuralNetwork;
using System.Runtime.CompilerServices;

namespace DataExtractionEngine
{
    internal class GlobalVars
    {
        public static string RootDir { get; set; } = "";

        public static string OutputPath { get; set; } = "";

        public static string NeuralNetworkPath { get; set; } = "";

        public static Network NeuralNetwork { get; set; } = GlobalVars.BuildDefaultNetwork();

        public static bool TrainNetwork { get; set; } = false; 

        public static string SearchPattern { get; set; } = "";

        public static bool OpenNewWindow { get; set; } = false;

        //public static Output Out { get; set; } = new(Application.StartupPath + @"\output.txt");

        public static bool ApplicationRunning { get; set; } = true;

        public static volatile List<string> GenerationFiles = [];

        public static bool TrainNetworkWindow { get; set; } = false;

        public static volatile List<Thread> WindowsList = [];

        public static volatile LoadingWindow Loader = new(); 

        public static Network.Builder Builder { get; set; } = new();

        public static Network BuildDefaultNetwork()
        {
            Network.Builder builder = new();
            builder
                   .SetNeuronsInputLayer(6) // Select the number of neurons (sensors) for the input layer
                   .SetNeuronsForLayers(5, 5, 5, 3) // Select the number of neurons for the other layers
                   .SetWeightsInitializer(InitializerWeights.Random) // Select a method for assigning an initial value for the weight of neurons
                   .SetBiasNeurons(true, InitializerBias.Ones) // Select a method for assigning an initial value for bias neurons
                   .SetActivationFunc(ActivationFunc.Sigmoid) // Select an activation function
                   .SetLearningOptimizing(LearningOptimizing.SGDM) // Select a method for optimizing neural network training
                   .SetLossFunc(LossFunc.MSE) // Select a loss function
                   .SetLearningRate(0.1F) // Select a learning rate
                   .SetMomentumRate(0.9F); // Select a momentum rate
            GlobalVars.Builder = builder;
            return builder.Build();
        }
    }
}

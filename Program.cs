using DataExtractionEngine.Windows;


namespace DataExtractionEngine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            GlobalVars.WindowsList = new(); 
            Thread CheckerThread = new(() =>
            {
                while (GlobalVars.ApplicationRunning)
                {
                    if (GlobalVars.OpenNewWindow)
                    {
                        GlobalVars.WindowsList.Add(new Thread(() =>
                        {
                            Application.Run(new FoundFiles());
                        }));
                        GlobalVars.WindowsList[^1].SetApartmentState(ApartmentState.STA);
                        GlobalVars.WindowsList[^1].Start();
                        GlobalVars.OpenNewWindow = false; 
                    }
                    if (GlobalVars.TrainNetworkWindow)
                    {
                        GlobalVars.WindowsList.Add(new Thread(() =>
                        {
                            try
                            {
                                GlobalVars.Loader = new(GlobalVars.GenerationFiles, GlobalVars.NeuralNetwork);
                                Application.Run(GlobalVars.Loader);
                            }
                            catch (ObjectDisposedException)
                            {
                                GlobalVars.Loader.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                {
                                    GlobalVars.Loader.Dispose();
                                });
                                GlobalVars.Loader = new();
                                GlobalVars.Loader.InitializeComponent();
                                GlobalVars.Loader.backgroundWorker.RunWorkerAsync();
                                GlobalVars.Loader.progressUpdater.RunWorkerAsync();
                                GlobalVars.Loader.ShowDialog();
                            }
                            catch (InvalidOperationException)
                            {
                                try
                                {
                                    GlobalVars.Loader.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                {
                                    GlobalVars.Loader.Dispose();
                                });
                                }
                                catch
                                {

                                }
                                GlobalVars.Loader = new(); 
                                GlobalVars.Loader.InitializeComponent();
                                GlobalVars.Loader.backgroundWorker.RunWorkerAsync();
                                GlobalVars.Loader.progressUpdater.RunWorkerAsync();
                                GlobalVars.Loader.ShowDialog(); 
                                
                            }
                        }));
                        GlobalVars.WindowsList[^1].SetApartmentState(ApartmentState.STA);
                        GlobalVars.WindowsList[^1].Start();
                        GlobalVars.TrainNetworkWindow = false;
                    }
                    if (GlobalVars.OpenDataViewer)
                    {
                        
                        GlobalVars.WindowsList.Add(new Thread(() =>
                        {
                            Application.Run(new DataViewer(GlobalVars.GenerationFiles));
                        }));
                        GlobalVars.WindowsList[^1].SetApartmentState(ApartmentState.STA);
                        GlobalVars.WindowsList[^1].Start();
                        GlobalVars.OpenDataViewer = false;
                    }
                }
            });
            CheckerThread.SetApartmentState(ApartmentState.STA);
            CheckerThread.Start(); 

            Application.Run(new StartupWindow());
            GlobalVars.ApplicationRunning = false; 
        }
    }
}
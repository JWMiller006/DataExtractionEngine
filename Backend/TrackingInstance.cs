using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataExtractionEngine.Backend
{
    internal class TrackingInstance
    {
        public TrackingInstance()
        {
        }

        public TrackingInstance(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);
            LoadData(lines);
        }

        public int GenerationalFrames { get; set; }

        public int TrackingFrames { get; set; }

        public Vector3 Distance { get; set; }

        public void LoadData(string[] lines)
        {
            string temp = lines[0]; 
            temp = temp.Replace("Final distance: (", "");
            temp = temp.Replace(")", "");
            temp = temp.Replace(" ", "");
            string[] parts = temp.Split(',');
            this.Distance = new Vector3(float.Parse(parts[0]), float.Parse(parts[1]), float.Parse(parts[2]));
            temp = lines[1];
            temp = temp.Replace("Genetic Frames: ", "");
            temp = temp.Replace(" ", "");
            this.GenerationalFrames = int.Parse(temp);
            temp = lines[2];
            temp = temp.Replace("Tracked Frames: ", "");
            temp = temp.Replace(" ", "");
            this.TrackingFrames = int.Parse(temp);
            return; 
        }
    }
}

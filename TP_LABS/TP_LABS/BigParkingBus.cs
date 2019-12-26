using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    class BigParkingBus
    {
        List<ParkingBus<IBus>> parkingStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;

        public BigParkingBus(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<ParkingBus<IBus>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new ParkingBus<IBus>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public ParkingBus<IBus> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        
        public bool SaveData(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine("CountLeveles:" + parkingStages.Count);
            foreach (var level in parkingStages)
            {
                    writer.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var bus = level[i];
                        if (bus != null)
                        {
                            if (bus.GetType().Name == "CommonBus")
                            {
                               writer.Write(i + ":CommonBus:");
                            }
                            if (bus.GetType().Name == "Bus")
                            {
                            writer.Write(i + ":Bus:");
                            }
                            writer.WriteLine(bus);
                        }
                    }
            }
            writer.Close();
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
            {

                int counter = -1;
                IBus bus = null;

                string temp = sr.ReadLine();
                if (temp.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(temp.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<ParkingBus<IBus>>(count);

                }
                else
                {
                    return false;
                }
                while (true)
                {

                    temp = sr.ReadLine();

                    if (temp == null)
                        break;
                    if (temp == "Level")
                    {
                        counter++;
                        parkingStages.Add(new ParkingBus<IBus>(countPlaces, pictureWidth, pictureHeight)); continue;
                    }

                    if (string.IsNullOrEmpty(temp))
                    {
                        continue;
                    }
                    if (temp.Split(':')[1] == "CommonBus")
                    {
                        bus = new CommonBus(temp.Split(':')[2]);
                    }
                    else if (temp.Split(':')[1] == "Bus")
                    {
                        bus = new Bus(temp.Split(':')[2]);
                    }

                    parkingStages[counter][Convert.ToInt32(temp.Split(':')[0])] = bus;

                }

            }
            return true;
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
    }
}

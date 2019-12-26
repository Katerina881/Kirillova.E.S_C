using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    class BigParkingBus
    {
        List<ParkingBus<IBus>> parkingStages;
        private const int countPlaces = 20;

        public BigParkingBus(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<ParkingBus<IBus>>(); for (int i = 0; i < countStages; ++i)
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
    }
}

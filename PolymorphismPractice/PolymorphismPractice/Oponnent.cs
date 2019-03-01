using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public class Opponent
    {
        private Lokacija lokacija;
        private Random random;

        public Opponent(Lokacija myLocation)
        {
            this.lokacija = myLocation;
            this.random = new Random();
        }

        public void Move()
        {
            bool hidden = false;

            while (!hidden) 
            {
                if (lokacija is IHasExteriorDoor)
                {
                    IHasExteriorDoor hasExteriorDoor = lokacija as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                    {
                        lokacija = hasExteriorDoor.DoorLocation;
                    } 
                }
                int rndNumber = random.Next(lokacija.Exits.Length);
                lokacija = lokacija.Exits[rndNumber];

                if (lokacija is IHiddingPlaces)
                {
                    hidden = true;
                }
            }
        }

        public bool Check(Lokacija currentLocation)
        {
            if (currentLocation != lokacija)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}

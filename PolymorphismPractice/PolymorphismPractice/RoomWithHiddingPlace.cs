using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public class RoomWithHiddingPlace : Room, IHiddingPlaces
    {
        public RoomWithHiddingPlace(string name, string decoration ,string[] hiddingPlace): base(name,decoration)
        {
            HiddingPlaceName = hiddingPlace;
        }
        public string[] HiddingPlaceName { get; private set; }

    }
}

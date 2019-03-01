using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public class OustsideWithHiddingPlace: Outside ,IHiddingPlaces
    {
        public OustsideWithHiddingPlace(string name, bool hot, string[]  hiddingPlace): base(name, hot)
        {
            HiddingPlaceName = hiddingPlace;
        }

        public string[] HiddingPlaceName { get; set; }
    }
}

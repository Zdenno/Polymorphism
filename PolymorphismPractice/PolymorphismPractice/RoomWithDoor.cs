using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public class RoomWithDoor: RoomWithHiddingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string[] hiddingplaces): base(name, decoration, hiddingplaces)
        {
            DoorDescription = doorDescription;
        }

        public override string Description
        {
            get
            {
                return base.Description + "You will see a " + DoorDescription.ToLower() +  "." + Environment.NewLine; 
            }
        }

        public string DoorDescription { get; private set; }

        public Lokacija DoorLocation { get; set; }
    }
}

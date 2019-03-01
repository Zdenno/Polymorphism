using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    interface IHasExteriorDoor
    {
         string DoorDescription { get;   }
         Lokacija DoorLocation { get; set; }

    }
}

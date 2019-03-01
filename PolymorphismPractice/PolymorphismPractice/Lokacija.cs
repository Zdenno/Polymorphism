using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public abstract class Lokacija
    {
        public string Name { get; set; }
        public Lokacija(string name )
        {
            Name = name;
        }

        public Lokacija[] Exits { get; set; }

        public virtual string Description
        {
            get
            {
                string description = "You are standing in " + Name + "." + Environment.NewLine;
                description += "You'll see exits in following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += Exits[i].Name.ToLower();
                    if (i != Exits.Length - 1) 
                    {
                        description += ", ";
                    }
                }
                description += "." + Environment.NewLine;
                return description;
            }

        }
    }
}

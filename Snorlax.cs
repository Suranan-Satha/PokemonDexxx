using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POkemonDExx
{
    public class Snorlax : Pokemon
    {
        public Snorlax() 
        {
            this.Type = PokemonType.normal;
            this.Height = 2.1;
            this.Weight = 460.0;
            this.HP = 160;
            this.Attack = 110;
            this.Defense = 65;
            this.SpecialAttack = 65;
            this.SpecialDefense = 110;
            this.Speed = 30;
            this.Total = 540;
            this.Name = "Snorlax";
            this.Species = "Sleeping Pokemon";
            this.image = Resource1.ResourceManager.GetObject("Snor") as byte[] ?? Array.Empty<byte>();

        }


    }
}

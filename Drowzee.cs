using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POkemonDExx
{
    public class Drowzee : Pokemon
    {
        public Drowzee() 
        {
            this.Type = PokemonType.psychic;
            this.Height = 1.0;
            this.Weight = 32.4;
            this.HP = 60;
            this.Attack = 48;
            this.Defense = 45;
            this.SpecialAttack = 43;
            this.SpecialDefense = 90;
            this.Speed = 42;
            this.Total = 328;
            this.Name = "Drowzee";
            this.Species = "Hypnosis Pokemon";
            this.image = Resource1.ResourceManager.GetObject("drowzee") as byte[] ?? Array.Empty<byte>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POkemonDExx
{
    public class Arbok : Pokemon
    {
        public Arbok()
        {
            this.Type = PokemonType.poison;
            this.Height = 3.5;
            this.Weight = 65.0;
            this.HP = 60;
            this.Attack = 85;
            this.Defense = 69;
            this.SpecialAttack = 65;
            this.SpecialDefense = 79;
            this.Speed = 80;
            this.Total = 438;
            this.Name = "Arbok";
            this.Species = "Cobra Pokemon";
            this.image = Resource1.ResourceManager.GetObject("arbok") as byte[] ?? Array.Empty<byte>();
        }
    }
}

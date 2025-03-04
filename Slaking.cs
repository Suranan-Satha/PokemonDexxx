using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POkemonDExx
{
    public class Slaking : Pokemon
    {
        public Slaking()
        {
            this.Type = PokemonType.normal;
            this.Height = 2.0;
            this.Weight = 130.5;
            this.HP = 150;
            this.Attack = 160;
            this.Defense = 100;
            this.SpecialAttack = 95;
            this.SpecialDefense = 65;
            this.Speed = 100;
            this.Total = 670;
            this.Name = "Slaking";
            this.image = Resource1.ResourceManager.GetObject("slaking") as byte[] ?? Array.Empty<byte>();
        }
    }
}

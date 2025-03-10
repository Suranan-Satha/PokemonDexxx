using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POkemonDExx
{
    public class Gengar : Pokemon
    {
        public Gengar() 
        {
            this.Type = PokemonType.poison;
            this.Height = 1.5;
            this.Weight = 40.5;
            this.HP = 60;
            this.Attack = 65;
            this.Defense = 60;
            this.SpecialAttack = 130;
            this.SpecialDefense = 75;
            this.Speed = 110;
            this.Total = 500;
            this.Name = "Gengar";
            this.Species = "Shadow Pokemon";
            this.image = Resource1.ResourceManager.GetObject("gengar") as byte[] ?? Array.Empty<byte>();
        }
    }
}

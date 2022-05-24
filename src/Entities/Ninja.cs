using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vitor_Silva.src.Entities
{
 public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou a Shuriken no Batman";
        }

        public string Attack(int Bonus){

            if (Bonus > 12){
                return this.Name + " Lançou uma flecha super explosiva com bonus de " + Bonus;
               } else{ 
                    return this.Name + " Lançou uma flecha de madeira com bonus de " + Bonus;
                }
            }
           
    }

}
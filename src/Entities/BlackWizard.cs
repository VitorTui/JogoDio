using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vitor_Silva.src.Entities
{
 public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou o feitiço maléficos das trevas";
        }

        public string Attack(int Bonus){

            if (Bonus > 12){
                return this.Name + " Lançou uma magia Boladona com forças de todos os magos do universo " + Bonus;
               } else{ 
                    return this.Name + " Lançou um truque fajuto de quinta " + Bonus;
                }
            }
           
    }

}
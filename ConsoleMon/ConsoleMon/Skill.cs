using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMon;

namespace ConsoleMon
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
        internal Elements element;

        internal Skill()
        {

        }

        internal Skill(Skill copyFrom)
        {
            this.damage = copyFrom.damage;
            this.energyCost = copyFrom.energyCost;
            this.name = copyFrom.name;
            this.element = copyFrom.element;
        }

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
}
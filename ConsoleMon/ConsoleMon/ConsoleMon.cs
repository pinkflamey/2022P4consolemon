using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal enum Elements
    {
        Vuur,
        Water,
        Aarde,
        Lucht,
        Glitter
    }
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        internal Elements weakness;

        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;
            this.weakness = copyFrom.weakness;

            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                Skill clone = new Skill(copyFrom.skills[i]);
                this.skills.Add(clone);
            }
        }

        List<Skill> skills = new List<Skill>();

        internal void TakeDamage(int damage)
        {
            health = health - damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
    }
}
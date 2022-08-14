using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private const double WarriorBaseHealt = 100;
        private const double WarriorBaseArmor = 50;
        private const double WarriorBaseAbilityPoints = 40;
        public Warrior(string name) : base(name, WarriorBaseHealt, WarriorBaseArmor, WarriorBaseAbilityPoints, new Satchel())
        {

        }
        public void Attack(Character character)
        {
            this.EnsureAlive();
            if (character.Equals(this))
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
            character.TakeDamage(abilityPoints);
        }
    }
}

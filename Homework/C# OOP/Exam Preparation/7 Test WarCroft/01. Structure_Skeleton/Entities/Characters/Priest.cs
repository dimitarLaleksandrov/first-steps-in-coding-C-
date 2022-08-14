using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private const double PriestBaseHealt = 50;
        private const double PriestBaseArmor = 25;
        private const double PriestBaseAbilityPoints = 40;
        public Priest(string name) : base(name, PriestBaseHealt, PriestBaseArmor, PriestBaseAbilityPoints, new Backpack())
        {

        }
        public void Heal(Character character)
        {
            EnsureAlive();
            if (character.IsAlive)
            {
                character.Health += abilityPoints;
            }
        }
    }
}

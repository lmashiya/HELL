using System;
using System.Collections.Generic;
using HELL.Interfaces;

namespace HELL.Entities.Heroes
{
    public class Assassin : Heroes,IHeroDefault    
    {
        public Assassin()
        {
            HeroSetup(string.Empty, HeroDefaultProperties());
        }

        public Dictionary<string, int> HeroDefaultProperties()
        {
            return new Dictionary<string, int>
            {
                {"Strength",25},
                {"Agility",100},
                {"Intelligence",15},
                {"HitPoints",150},
                {"Damage",300},
            };

        }
    }
}
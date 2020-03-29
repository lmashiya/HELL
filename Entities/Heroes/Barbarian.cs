using System;
using System.Collections.Generic;
using HELL.Interfaces;

namespace HELL.Entities.Heroes
{
    public class Barbarian : Heroes,IHeroDefault
    {
        public Barbarian()
        {
            HeroSetup(string.Empty, HeroDefaultProperties());
        }

        public Dictionary<string, int> HeroDefaultProperties()
        {
            return new Dictionary<string, int>
            {
                {"Strength",90},
                {"Agility",25},
                {"Intelligence",10},
                {"HitPoints",350},
                {"Damage",150},
            };

        }
    }
}
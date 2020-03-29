using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HELL.Interfaces;

namespace HELL.Entities.Heroes
{
    public class Wizard : Heroes,IHeroDefault
    {
        public Wizard()
        {
            HeroSetup(String.Empty, HeroDefaultProperties());
        }

        public Dictionary<string, int> HeroDefaultProperties()
        {
            return new Dictionary<string,int>
            {
                {"Strength",25},
                {"Agility",25},
                {"Intelligence",100},
                {"HitPoints",100},
                {"Damage",250},
            };

        }
    }
}
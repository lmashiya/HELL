using System.Collections.Generic;
using HELL.Entities.Heroes;

namespace HELL.Entities.Inventory
{
    public static class Inventory
    {
        public static List<Heroes.Heroes> ChosenHeroes { get; set; }

        static Inventory()
        {
            ChosenHeroes = new List<Heroes.Heroes>();
        }
        public static List<Heroes.Heroes> AvailableHeroes()
        {
            return new List<Heroes.Heroes>
            {
                new Wizard() ,
                new Assassin() ,
                new Barbarian()
            };
        }

        public static Heroes.Heroes GetHero(string heroName)
        {
            return Inventory.ChosenHeroes.Find(x => x.Properties.Name.Contains(heroName));
        }

    }
}
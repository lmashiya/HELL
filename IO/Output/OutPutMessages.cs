using System;
using HELL.Entities.Heroes;
using HELL.Entities.Items;

namespace HELL.IO.Output
{
    public static class OutPutMessages
    {
        public static void AddedItemMessage(Items item)
        {
            Console.WriteLine($"Added item - {item.Name} to Hero - {item.HeroName}");

        }
        public static void AddedRecipeMessage(Items item)
        {
            Console.WriteLine($"Added recipe - {item.Name} to Hero -{item.HeroName}");

        }
        public static void CreatedHeroMessage(Heroes hero)
        {
            Console.WriteLine($"Created {hero.GetType().Name} - {hero.Properties.Name}");

        }

    }
}
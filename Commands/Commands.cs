using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using HELL.Entities.Heroes;
using HELL.Entities.Inventory;
using HELL.Entities.Items;
using HELL.Interfaces;
using HELL.IO.Input;
using HELL.IO.Output;

namespace HELL.Commands
{
    public class Commands
    {

        

        public void QuitCommand(string[] userInput)
        {
            var orderedList = Inventory.ChosenHeroes.OrderBy(x => x.SumOfThreeHeroItemProperties()).ThenBy(x => x.SumOfTwoHeroItemProperties());
            foreach (var item in orderedList)
            {
                Console.WriteLine($"{item.GetType().Name} : {item.Properties.Name}");
                item.HeroItemDescription();
                item._heroItems.ForEach(x => Console.WriteLine(x.Name));
            }
        }

        public void InspectCommand(string[] userInput)
        {
            var hero = Inventory.GetHero(userInput[1]);
            hero.HeroDescription();
        }

       public void RecipeCommand(string[] userInput)
        {
            var hero = Inventory.GetHero(userInput[2]);
            if (hero._heroItems.Count > 1 )
            {
               var isItemsPresent = IsItemsPresent(userInput,Inventory.GetHero(userInput[2]));
               if (isItemsPresent == 2)
               {
                    var recipe = new RecipeItem(userInput);
                    hero._heroItems.Add(new CommonItem(recipe));
                    hero.IncreaseHeroPropertyByItem(recipe);
                    OutPutMessages.AddedRecipeMessage(recipe);
               }
            }
        }

        public int IsItemsPresent(string[] userInput,Heroes hero)
        {
            int isItemsPresent = 0;
            foreach (var item in hero._heroItems.ToList())
            {
                if (item.Name == userInput[8] || item.Name == userInput[9])
                {
                    isItemsPresent += 1;
                    hero._heroItems.RemoveAll(x => x.Name == item.Name);
                }
            }
            
            return isItemsPresent;
        }


        public void ItemCommand(string[] userInput)
        {
            var item = new CommonItem(userInput);
            var hero = Inventory.GetHero(item.HeroName);
            hero._heroItems.Add(item);
            hero.IncreaseHeroPropertyByItem(item);
            OutPutMessages.AddedItemMessage(item);
           
        }

        public void HeroCommand(string heroName, string type)
        {
            foreach (var hero in Inventory.AvailableHeroes())
            {
                if (hero.GetType().ToString().Contains(type))
                {
                    hero.Properties.Name = heroName;
                    Inventory.ChosenHeroes.Add(hero);
                    OutPutMessages.CreatedHeroMessage(hero);
                }

            }
        }

    }
}
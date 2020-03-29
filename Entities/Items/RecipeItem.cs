using System;
using System.Linq;
using HELL.Interfaces;
using HELL.IO.Input;

namespace HELL.Entities.Items
{
    public class RecipeItem : Items,IItems
    {
        //TODO : have to get the required items from the CommonItems
        private CommonItem RequiredItem { get; set; }
        private CommonItem RequiredItem2 { get; set; }

        public RecipeItem(string[] userInputs)
        {
            SetItemProperties(userInputs);
        }
        public void SetItemProperties(string[] userInput)
        {
            Name = userInput[1];
            HeroName = userInput[2];
            StrengthBonus = Convert.ToInt32(userInput[3]);
            AgilityBonus = Convert.ToInt32(userInput[4]);
            IntelligenceBonus = Convert.ToInt32(userInput[5]);
            HitPointsBonus = Convert.ToInt32(userInput[6]);
            DamageBonus = Convert.ToInt32(userInput[7]);
            RequiredItem = null;
            RequiredItem2 = null;
        }

        public Items GetRequiredItem()
        {
            return this.RequiredItem;
        }

        public Items GetRequiredItem2()
        {
            return this.RequiredItem2;
        }
    }
}
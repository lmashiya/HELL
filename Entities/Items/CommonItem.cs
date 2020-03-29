using System;
using System.Runtime.CompilerServices;
using HELL.Interfaces;
using HELL.IO.Input;

namespace HELL.Entities.Items
{
    public class CommonItem : Items,IItems
    {
        public CommonItem(RecipeItem recipe)
        {
            SetRecipeProperties(recipe);
        }

        public CommonItem(string[] userInput)
        {
            SetItemProperties(userInput);
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
        }

        public void SetRecipeProperties(RecipeItem recipe)
        {
            Name = recipe.Name;
            HeroName = recipe.HeroName;
            StrengthBonus = recipe.StrengthBonus;
            AgilityBonus = recipe.AgilityBonus;
            IntelligenceBonus = recipe.IntelligenceBonus;
            HitPointsBonus = recipe.HitPointsBonus;
            DamageBonus = recipe.DamageBonus;
        }

        public CommonItem GetCommonItem(string name)
        {
            if (this.Name == name)
                return this;
            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using HELL.Entities.Items;

namespace HELL.Entities.Heroes
{
    public class Heroes
    {
        public List<Items.Items> _heroItems { get;}
        public HeroProperties Properties { get;}

        public Heroes()
        {
            _heroItems = new List<Items.Items>();
            Properties = new HeroProperties();
        }

        public List<string> HeroList()
        {
            return new List<string>
            {
                { "Barbarian"},
                {"Assassin" },
                {"Wizard"}
            };
        }

        public void HeroSetup(string name, Dictionary<string,int> defaultProperties)
        {
            Properties.Name = name;
            Properties.Strength = defaultProperties["Strength"];
            Properties.Agility = defaultProperties["Agility"];
            Properties.Intelligence = defaultProperties["Intelligence"];
            Properties.HitPoints = defaultProperties["HitPoints"];
            Properties.Damage = defaultProperties["Damage"];
        }

        public void IncreaseHeroPropertyByItem(Items.Items item)
        {
            this.Properties.Strength += item.StrengthBonus;
            this.Properties.Agility += item.AgilityBonus;
            this.Properties.Intelligence += item.IntelligenceBonus;
            this.Properties.HitPoints += item.HitPointsBonus;
            this.Properties.Damage += item.DamageBonus;
        }

        public void HeroDescription()
        {
            Console.WriteLine($"Hero: {this.Properties.Name}, Class: {this.GetType().Name}\n" +
                              $"HitPoints: {this.Properties.HitPoints}, Damage: {this.Properties.Damage}\n" +
                              $"Strength: {this.Properties.Strength}\nAgility: {this.Properties.Agility}\n" +
                              $"Intelligence: {this.Properties.Intelligence}");
            HeroItemDescription();
        }

        public void HeroItemDescription()
        {
            if (this._heroItems.Count >= 1)
            {
                foreach (var item in this._heroItems)
                {
                    Console.WriteLine($"Items:\n###Item: {item.Name}\n###+{item.StrengthBonus} Strength\n" +
                                      $"###+{item.AgilityBonus} Agility\n###+{item.IntelligenceBonus} Intelligence\n" +
                                      $"###+{item.HitPointsBonus} HitPoints\n###+{item.DamageBonus} Damage");
                }
            }
            else
                Console.WriteLine($"###Items: None");
        }

        public int SumOfThreeHeroItemProperties()
        {
            return this.Properties.Damage + this.Properties.Agility + this.Properties.Intelligence;
        }
        public int SumOfTwoHeroItemProperties()
        {
            return this.Properties.HitPoints + this.Properties.Strength ;
        }
    }
}
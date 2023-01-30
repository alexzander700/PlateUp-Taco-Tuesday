using System;
using KitchenLib.Customs;
using System.Collections.Generic;
using KitchenData;
using KitchenMods;

namespace TacoTuesday.CustomFood.BaseTaco
{
    public class BaseTaco : CustomDish
    {
        public override string UniqueNameID => "Taco -- Base";
        public override DishType Type => DishType.Base;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => UnlockGroup.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedHardBeefTaco
            }
        };
        public override HashSet<Dish.IngredientUnlock> IngredientUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.
                MenuItem = Mod.PlatedHardBeefTaco
            }
        };



    }
}

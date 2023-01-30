using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using KitchenMods;
using UnityEngine;
using KitchenLib;
using KitchenLib.References;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenData;
using ItemReference = KitchenLib.References.ItemReferences;

namespace PlateUp_Taco_Tuesday
{
    class Mod : BaseMod, IModSystem
    {
        internal const string MOD_GUID = "mod.alexzander700.plateup.tacotuesday";
        internal const string MOD_ID = "TacoTuesday";
        internal const string MOD_NAME = "Taco Tuesday";
        internal const string MOD_VERSION = "1.0.0";
        internal const string MOD_AUTHOR = "alexzander700";
        internal const string PLATEUP_VERSION = "1.1.2";

        internal static Item Cheese => GetExistingGDO<Item>(ItemReference.Cheese);

        internal static Process Cook => GetExistingGDO<Process>(ProcessReferences.Cook);
        internal static Process Chop => GetExistingGDO<Process>(ProcessReferences.Chop);

        internal static Item Cheese => GetExistingGDO<Item>(ItemReference.Cheese);
        private void AddRecipies()
        {
            
        }




        protected override void Initialise()
        {
            base.Initialise();

            AddGameDataObject<Tortilla>();
            AddGameDataObject<TortillaShell>();
            AddGameDataObject<TortillaChips>();

            AddGameDataObject<BeefHardTaco>();
        }


        private static T1 GetModdedGDO<T1, T2>() where T1 : GameDataObject
        {
            return (T1)GDOUtils.GetCustomGameDataObject<T2>().GameDataObject;
        }
        private static T GetExistingGDO<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id);
        }
        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, PLATEUP_VERSION, Assembly.GetExecutingAssembly()) { }
    }


}

using BepInEx;
using ItemManager;

namespace CatBall
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class CatBall : BaseUnityPlugin
    {
        private const string ModName = "CatBall";
        private const string ModVersion = "2.0.6";
        private const string ModGUID = "org.bepinex.plugins.catball";

        public void Awake()
        {
            Item CatBall = new Item("ball", "CatBall", "Balls");
            CatBall.Crafting.Add(CraftingTable.Forge, 3);
            CatBall.RequiredItems.Add("Iron", 20);
            CatBall.RequiredItems.Add("WolfFang", 4);
            CatBall.RequiredItems.Add("Wood", 6);
            CatBall.RequiredUpgradeItems.Add("Iron", 5);
            CatBall.RequiredUpgradeItems.Add("WolfFang", 5);
            CatBall.CraftAmount = 1;

        }
    }
}
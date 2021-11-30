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
            CatBall.RequiredItems.Add("LeatherScraps", 40);
            CatBall.RequiredItems.Add("TrollHide", 4);
            CatBall.RequiredItems.Add("SurtlingCore", 6);
            CatBall.RequiredUpgradeItems.Add("LeatherScraps", 5);
            CatBall.RequiredUpgradeItems.Add("TrollHide", 2);
            CatBall.RequiredUpgradeItems.Add("SurtlingCore", 1);
            CatBall.CraftAmount = 1;

        }
    }
}
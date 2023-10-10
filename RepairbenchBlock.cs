using Oxide.Core;

namespace Oxide.Plugins
{
    [Info("Repairbench Block" , "Krungh Crow", "1.0.1")]
    [Description("Disables using the repairbench")]

    class RepairbenchBlock : RustPlugin
    {
        void Init() => permission.RegisterPermission("repairbenchblock.bypas" , this);

        private object CanLootEntity(BasePlayer player, RepairBench repairbench)
        {

            if (player == null || repairbench == null) return null;
            if (permission.UserHasPermission(player.UserIDString, "repairbenchblock.bypas")) return null;
            return false;
        }
    }
}

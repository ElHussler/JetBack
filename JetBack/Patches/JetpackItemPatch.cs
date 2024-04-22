using HarmonyLib;

namespace JetBack.Patches
{
    [HarmonyPatch(typeof(JetpackItem))]
    internal class JetpackItemPatch
    {
        [HarmonyPatch(nameof(JetpackItem.Update))]
        [HarmonyPrefix]
        static void UnnerfJetpackPatch(ref float ___jetpackAcceleration, ref float ___jetpackDeaccelleration)
        {
            ___jetpackAcceleration = 10f;
            ___jetpackDeaccelleration = 45f;
        }
    }
}

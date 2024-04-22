using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JetBack.Patches;

namespace JetBack
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class JetBackBase : BaseUnityPlugin
    {
        private const string modGUID = "Hussler.JetBack";
        private const string modName = "JetBack";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static JetBackBase instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("JetBack is blasting off again!");

            harmony.PatchAll(typeof(JetBackBase));
            harmony.PatchAll(typeof(JetpackItemPatch));
        }
    }
}

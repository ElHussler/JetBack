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

        void Awake()
        {
            //Add logging
            
            //Apply Patches
        }
    }
}

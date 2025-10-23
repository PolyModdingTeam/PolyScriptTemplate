using BepInEx.Logging;
using HarmonyLib;

namespace PolyScriptTemplate;
public static class Main
{
    public static ManualLogSource? modLogger;
    public static void Load(ManualLogSource logger)
    {
        modLogger = logger;
        modLogger.LogMessage("Here we go!");
        Harmony.CreateAndPatchAll(typeof(Main));
    }
}

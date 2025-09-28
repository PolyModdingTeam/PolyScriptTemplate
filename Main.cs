using BepInEx.Logging;
using PolyMod;

namespace PolyScriptTemplate;
public class Main : PolyScriptMod
{
    public override void Load()
    {
        this.Logger.LogMessage("Here we go!");
    }
    public override void UnLoad()
    {
    }
}

using MelonLoader;

namespace TnTRF_4_Players_Mod
{
    public class Main : MelonMod
    {
        public static Main Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            Instance = this;
            LoggerInstance.Msg("TnTRF 4 Players Mod has started!");
        }
    }
}

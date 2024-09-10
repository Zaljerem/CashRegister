using HarmonyLib;
using UnityEngine;
using Verse;

namespace CashRegister
{
    [StaticConstructorOnStartup]
    public class Mod_CashRegister : Mod
    {
        public static ModSettings_CashRegister settings;
        public Mod_CashRegister(ModContentPack content) : base(content)
        {
            settings = GetSettings<ModSettings_CashRegister>();
            Harmony harmony = new Harmony(this.Content.PackageIdPlayerFacing);
            harmony.PatchAll();
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            settings.DoSettingsWindowContents(inRect);
        }
        public override string SettingsCategory()
        {
            return "CashRegister";
        }
        public override void WriteSettings()
        {
            base.WriteSettings();
        }
       
    }
}
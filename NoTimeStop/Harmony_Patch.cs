using Harmony;
using System.Reflection;
using System;
using System.IO;
using UnityEngine;

namespace NoTimeStop_MOD
{
    public class Harmony_Patch
    {
        public Harmony_Patch()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("Tundra.NoTimeStop");
            try
            {
                harmony.Patch(typeof(PlaySpeedSettingUI).GetMethod("CheckTimeStopBlocked", BindingFlags.Instance | BindingFlags.NonPublic), null, new HarmonyMethod(typeof(Harmony_Patch).GetMethod("BreakHokmahJob")), null);
            }
            catch (Exception e)
            {
                File.AppendAllText(Application.dataPath + "/BaseMods/Error.log", e.Message);
            }
        }

        public static void BreakHokmahJob(ref bool __result)
        {
            __result = true;
        }
    }
}

using Harmony;
using System;
using System.IO;
using UnityEngine;

namespace DoubleQuotaEnergy
{
    public class Harmony_Patch
    {
        public Harmony_Patch()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("Tundra.DoubleQuotaEnergy");
            try
            {
                harmony.Patch(typeof(StageTypeInfo).GetMethod("GetEnergyNeed"), null, new HarmonyMethod(typeof(Harmony_Patch).GetMethod("LetsTreeOfLight")), null);
            }
            catch (Exception e)
            {
                File.AppendAllText(Application.dataPath + "/BaseMods/Error.log", e.Message);
            }
        }

        public static void LetsTreeOfLight(ref float __result)
        {
            __result += __result;
        }
    }
}

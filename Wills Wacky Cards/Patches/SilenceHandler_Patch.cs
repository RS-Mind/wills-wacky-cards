﻿using HarmonyLib;
using UnityEngine;
using WWC.Extensions;
using WWC.MonoBehaviours;
using Sonigon;
using UnboundLib;

namespace WWC.Patches
{
    [HarmonyPatch(typeof(SilenceHandler))] 
    class SilenceHandler_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Update")]
        static void WillpowerSpeedUp(SilenceHandler __instance, CharacterData ___data)
        {
            var data = ___data;
            if (data.stats.GetAdditionalData().willpower != 0f && data.silenceTime > 0f)
            {
                data.silenceTime -= TimeHandler.deltaTime * data.stats.GetAdditionalData().willpower;
            }
        }

        //[HarmonyPrefix]
        //[HarmonyPatch("SomeMethod")]
        //static void MyMethodName()
        //{

        //}

        //[HarmonyPostfix]
        //[HarmonyPatch("SomeMethod")]
        //static void MyMethodName()
        //{

        //}
    }
}
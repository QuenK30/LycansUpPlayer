﻿using BepInEx;
using LycansUpPlayer.Utils;
using LycansUpPlayer.Patchs;
using UnityEngine;
using HarmonyLib;
namespace LycansUpPlayer
{

    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    [BepInProcess("Lycans.exe")]
    public class LycansUpPlayerPlugin : BaseUnityPlugin
    {
        public static Settings settings;
        public const string PLUGIN_GUID = $"nm-qm.lycans-up-player";
        public const string PLUGIN_AUTHOR = "NM & QM";
        public const string PLUGIN_NAME = "LycansUpPlayer";
        public const string PLUGIN_FOLDER = "LycansUpPlayer";
        public const string PLUGIN_VERSION = "1.0.0";
        


        private void Awake()
        {
            Log.Init(Logger);
            Log.Info($"{PLUGIN_NAME} v{PLUGIN_VERSION} loaded");
            settings = new Settings(Config);
           // GameSettingsMenuPatch.Hook();
            LycansUpPlayerUI.Hook();

            var harmony = new Harmony(PLUGIN_GUID);
            harmony.PatchAll();
        }

        private void Update()
        {
        }
    }

}
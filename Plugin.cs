using System.IO;
using BepInEx;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;
using VladyslavMenu.Managers;

namespace VladyslavMenu
{
    [System.ComponentModel.Description(PluginInfo.Description)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void Awake()
        {
            GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);
            Logger.LogInfo($"\r\n" +
                           $" ▌ ▐·▄▄▌   ▄▄▄· ·▄▄▄▄   ▄· ▄▌.▄▄ · ▄▄▌   ▄▄▄·  ▌ ▐·  .▄▄ ·   • ▌ ▄ ·. ▄▄▄ . ▐ ▄ ▄• ▄▌\r\n" +
                           $"▪█·█▌██•  ▐█ ▀█ ██· ██ ▐█▪██▌▐█ ▀. ██•  ▐█ ▀█ ▪█·█▌  ▐█ ▀.   ·██ ▐███▪▀▄.▀·•█▌▐██▪██▌\r\n" +
                           $"▐█▐█•██ ▪ ▄█▀▀█ ▐█▪ ▐█▌▐█▌▐█▪▄▀▀▀█▄██ ▪ ▄█▀▀█ ▐█▐█•  ▄▀▀▀█▄  ▐█ ▌▐▌▐█·▐▀▀▪▄▐█▐▐▌█▌▐█▌\r\n" +
                           $" ███ ▐█▌ ▄▐█▪ ▐▌██. ██  ▐█▀·.▐█▄▪▐█▐█▌ ▄▐█▪ ▐▌ ███   ▐█▄▪▐█  ██ ██▌▐█▌▐█▄▄▌██▐█▌▐█▄█▌\r\n" +
                           $". ▀  .▀▀▀  ▀  ▀ ▀▀▀▀▀•   ▀ •  ▀▀▀▀ .▀▀▀  ▀  ▀ . ▀     ▀▀▀▀   ▀▀  █▪▀▀▀ ▀▀▀ ▀▀ █▪ ▀▀▀ \r\n" +
                           $"                              {PluginInfo.Name}                                   \r\n" +
                           $"                            {PluginInfo.Description}                                   \r\n" +
                           $"                                    {PluginInfo.Version}                                   \r\n");

            if (File.Exists(FileAndFolderManager.MenuFolderDirectory) == false)
            {
                FileAndFolderManager.CreateMenuFolders();
            }
        }
        public void OnPlayerSpawned()
        {
            Patches.PatchHandler.PatchAll();
            //IDS.MakeYourIdYourId();
            //FileAndFolderManager.LoadModsOrSettings();
        }
    }
}

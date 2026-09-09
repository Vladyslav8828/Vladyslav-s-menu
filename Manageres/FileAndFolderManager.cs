using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Collections;
using System.IO;
using BepInEx;
using System.Reflection;
using VladyslavMenu.Menu;
using VladyslavMenu.Classes;
using UnityEngine.InputSystem.Composites;
using Photon.Pun.UtilityScripts;
using System.Dynamic;
using VladyslavMenu.Managers;
using VladyslavMenu.Notifications;
using static VladyslavMenu.Menu.Buttons;
using static VladyslavMenu.Settings;
using GorillaExtensions;

namespace VladyslavMenu.Managers
{
    internal class FileAndFolderManager
    {
        public static string PluginDirectory => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string BeplnExDirectory => Directory.GetParent(PluginDirectory).FullName;
        public static string GameDirectory => Directory.GetParent(BeplnExDirectory).FullName;

        public static string MenuFolderDirectory = Path.Combine(GameDirectory, "Vladyslavs Menu");
        public static string SavedModsOrSettingsFile = Path.Combine(MenuFolderDirectory, "Save.json");

        public static float UserModsOrSettingsColdown = 20f; //twety second coldow (sorry if i spelled it worng my english is not very good :[)

        public static List<string> ModsToBeSaved = new List<string>();

        public static void Update()
        {
            if (UserModsOrSettingsColdown <= 0f)
            {
                UserModsOrSettingsColdown = 20f;

                

                SaveModsOrSettings();

                Debug.Log("Mods/Settings Saved");
            }
            else
            {
                FileAndFolderManager.UserModsOrSettingsColdown = UserModsOrSettingsColdown - Time.deltaTime;
            }
        }

        public static void SaveModsOrSettings()
        {
            foreach (var Category in buttons)
            {
                foreach (ButtonInfo button in Category)
                {
                    if (button.enabled == true)
                    {
                        ModsToBeSaved.Add(button.buttonText); 
                    }
                }
            }
            File.Delete(SavedModsOrSettingsFile);
            string bullshitToShit = string.Join("\n", ModsToBeSaved);
            File.WriteAllText(SavedModsOrSettingsFile, bullshitToShit);
        }
        public static void LoadModsOrSettings()
        {
            if (File.Exists(SavedModsOrSettingsFile))
            {
                string[] lines = File.ReadAllLines(SavedModsOrSettingsFile);

                foreach (var Category in buttons)
                {
                    foreach (ButtonInfo button in Category)
                    {
                        foreach (string line in lines)
                        {
                            
                            if (SavedModsOrSettingsFile.Contains(button.buttonText))
                            {
                                button.enabled = true;
                            }
                            else
                            {
                                button.enabled = false;
                            }
                        }
                    }
                }
            }
        }

        //just a reminder for later to use strings when writing files to a folder :)
        public static void CreateMenuFolders()
        {
            Directory.CreateDirectory(FileAndFolderManager.MenuFolderDirectory);
        }
    }
}
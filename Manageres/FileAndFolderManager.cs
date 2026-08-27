using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Collections;
using System.IO;
using BepInEx;
using System.Reflection;

namespace VladyslavMenu.Managers
{
    internal class FileAndFolderManager
    {
        public static string PluginDirectory => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string BeplnExDirectory => Directory.GetParent(PluginDirectory).FullName;
        public static string GameDirectory => Directory.GetParent(BeplnExDirectory).FullName;

        public static string MenuFolderDirectory = Path.Combine(GameDirectory, "Vladyslavs Menu");
        public static string SettingsFolderDirectory = Path.Combine(MenuFolderDirectory, "Settings");
    }
}

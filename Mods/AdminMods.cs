//only stuf that will not piss you off ig or smth
using VladyslavMenu.Managers;
using Photon;
using System.IO.Pipes;
using System.IO;
using BepInEx.Logging;
using UnityEngine;
using VladyslavMenu.Notifications;
using System.Diagnostics;
using ExitGames.Client.Photon;

namespace VladyslavMenu.Mods
{
    public class AdminMods
    {
        public static void Announcement()
        {
            string AnnouncementMessagePath = Path.Combine(FileAndFolderManager.MenuFolderDirectory, "Announcemnt.txt");
            // this will not be created you make the file and write somebullshit in it and it will send that to other menu users in the lobby with you and wtf is this sooo long XD
            if (File.Exists(AnnouncementMessagePath))
            {
                string[] FileShit = File.ReadAllLines(AnnouncementMessagePath); //only one line messages ig
                string announcemntsMessage = FileShit[0];
                if (FileShit.Length == 0)
                {
                    UnityEngine.Debug.LogError("File Announcemnt.txt is empty");
                    NotifiLib.SendNotificationError("File Announcemnt.txt is empty");
                    return;
                }

                //RoomAnnouncemnts.sender(announcemntsMessage);
            }
            else
            {
                UnityEngine.Debug.LogError("failed to find Announcemnt.txt");
                NotifiLib.SendNotificationError("failed to find Announcemnt.txt");
            }
        }
    }
}
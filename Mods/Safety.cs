using GorillaLocomotion;
using VladyslavMenu.Classes;
using VladyslavMenu.Notifications;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using static VladyslavMenu.Classes.RigManager;
using static VladyslavMenu.Menu.Main;
using ExitGames.Client.Photon;
using GorillaNetworking;
using GorillaTagScripts;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.Unity;
using VladyslavMenu.Menu;
using VladyslavMenu.Patches.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using Random = UnityEngine.Random;

namespace VladyslavMenu.Mods
{
    public class Safety
    {
        public static VRRig reportRig;
        public static void AntiReport(System.Action<VRRig, Vector3> onReport)
        {
            if (!NetworkSystem.Instance.InRoom) return;

            if (reportRig != null)
            {
                onReport?.Invoke(reportRig, reportRig.transform.position);
                reportRig = null;
                return;
            }

            foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
            {
                if (line.linePlayer != NetworkSystem.Instance.LocalPlayer) continue;
                Transform report = line.reportButton.gameObject.transform;

                foreach (var vrrig in from vrrig in VRRigExtensions.ActiveRigs where !vrrig.isLocal let D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position) let D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position) where D1 < 0.35f || D2 < 0.35f select vrrig)
                    onReport?.Invoke(vrrig, report.transform.position);
            }
        }

        public static float antiReportDelay;
        public static void AntiReportDisconnect()
        {
            AntiReport((vrrig, position) =>
            {
                NetworkSystem.Instance.ReturnToSinglePlayer();

                if (!(Time.time > antiReportDelay)) return;
                antiReportDelay = Time.time + 1f;
                NotifiLib.SendNotification("<color=grey>[</color><color=purple>ANTI-REPORT</color><color=grey>]</color> " + GetPlayerFromVRRig(vrrig).NickName + " attempted to report you, you have been disconnected.");
            });
        }
        public static void AntiReportReconnect()//seralyth
        {
            AntiReport((vrrig, position) =>
            {
                if (!(Time.time > antiReportDelay)) return;
                Room_mods.Reconnect();

                antiReportDelay = Time.time + 1f;
                NotifiLib.SendNotification("<color=grey>[</color><color=purple>ANTI-REPORT</color><color=grey>]</color> " + GetPlayerFromVRRig(vrrig).NickName + " attempted to report you, you have been disconnected and will be reconnected.");
            });
        }
    }
}

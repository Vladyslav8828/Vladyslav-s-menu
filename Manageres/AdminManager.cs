/*//quick note this is not for like kicking shit or like console and only is for in game announcemnts or smth might add some funny bullshit XD :)
using UnityEngine;
using GorillaExtensions;
using GorillaGameModes;
using GorillaLocomotion;
using GorillaNetworking;
using GorillaTag;
using GorillaTagScripts;
using GorillaUtil;
using VladyslavMenu.Notifications;
using Photon;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;
using PlayFab;
using Liv.Lck.Core;
using Modio;

//i might chnage my mind making this    XD

namespace VladyslavMenu.Managers
{
    public class RoomAnnouncemnts : MonoBehaviour, IOnEventCallback
    {
        public static byte SillyGooberAnnoucemntXD = 62; //idk like connection numbrt or smth

        public void OnEnable()
        {
            PhotonNetwork.AddCallbackTarget(this);
        }

        public void OnDisable()
        {
            PhotonNetwork.RemoveCallbackTarget(this);
        }

        public void OnEvent(EventData photonEventShit)
        {
            if (photonEventShit.Code == SillyGooberAnnoucemntXD)
            {
                object[] data = (object[])photonEventShit.CustomData;
                string message = (string)data[0];

                NotifiLib.SendNotification("<color=grey>[</color><color=orange>ANNOUNCEMENT</color><color=grey>]" + message);
            }
        }

        public static void sender(string messageXD)
        {
            object[] data = new object[] { messageXD };
            PhotonNetwork.RaiseEvent(
                SillyGooberAnnoucemntXD, 
                data, 
                new RaiseEventOptions { Receivers = ReceiverGroup.All }, 
                SendOptions.SendReliable
                );
        }
    }
    public class IDS
    {
        public static string YourId = null;

        public static string Vladyslav = "place holder";

        public static void MakeYourIdYourId()
        {
            PlayFab.PlayFabClientAPI.GetAccountInfo(
                new PlayFab.ClientModels.GetAccountInfoRequest(),
                Result => {
                    string UserPlayfabId = Result.AccountInfo.PlayFabId;

                    YourId = UserPlayfabId; //makes the cool ass string be your id
                },

                error => {
                    Debug.Log("Faild to get playfab Id");
                    NotifiLib.SendNotificationError("Faild to get playfab Id");
                }
            );
        }
    }
}*/
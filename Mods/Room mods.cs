using GorillaNetworking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using VladyslavMenu.Managers;

namespace VladyslavMenu.Mods
{
    internal class Room_mods
    {
        public static IEnumerator QueueRoomCoroutine(string roomName)
        {
            NetworkSystemPUN instance = (NetworkSystemPUN)NetworkSystem.Instance;

            instance.ReturnToSinglePlayer();
            yield return new WaitUntil(() => instance.netState == NetSystemState.Idle);
            yield return new WaitForSeconds(0.5f);

            // instance.netState = NetSystemState.Connecting;

            while (!instance.InRoom)
            {
                PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(roomName, JoinType.Solo);
                yield return new WaitForSeconds(reconnectDelay);
            }
        }

        public static Coroutine queueCoroutine;
        public static int reconnectDelay = 1;
        public static void Reconnect()
        {
            string roomName = NetworkSystem.Instance.RoomName;

            NetworkSystem.Instance.ReturnToSinglePlayer();
            QueueRoom(roomName);
        }
        public static void QueueRoom(string roomName)
        {
            if (queueCoroutine != null)
                CoroutineManager.instance.StopCoroutine(queueCoroutine);

            queueCoroutine = CoroutineManager.instance.StartCoroutine(QueueRoomCoroutine(roomName));
        }
    }
}

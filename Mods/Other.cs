#nullable disable
#pragma warning disable CS0649
using GorillaTag;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using VladyslavMenu.Notifications;
using VladyslavMenu.Managers;

namespace VladyslavMenu.Mods
{
    internal class Other
    {
        #region OgMonkeyBlocks broken new upd
        /*
        public static void OgMonkeyBlocksOn()
        {
            GameObject AtticBoards = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/UnityTempFile-941e523569aaac94dbfe635ec31d4a47 (combined by EdMeshCombiner)");
            GameObject AtticBlocker = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/UnityTempFile-1bf5a2ce6d8a1da49a68b9d224fbc6c0 (combined by EdMeshCombiner)");
            GameObject DummyAttic = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/DummyAttic");
            GameObject AtticBlockerInv = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/AtticBlockWithBoardsTight");
            GameObject AtticBlockerInv2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/sky jungle entrance 2");
            GameObject StumpElevator = GameObject.Find("Environment Objects/05Maze_PersistentObjects/GhostReactorElevatorManager/StumpElevator");
            GameObject StumpInside = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/UnityTempFile-96e104909c003c841a6115fd3306a3a3 (combined by EdMeshCombiner)");
            StumpInside.SetActive(false);
            GameObject TunnelToAttic = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/TunnelToAttic");
            GameObject InvTreeWood_Nohole = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/tree/TreeWood_NoHole");
            GameObject AtticSign = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/AtticSign");
            //GameObject AtticSignUI = GameObject.Find("");
            //GameObject AtticSignUINew = GameObject.Find("");
            GameObject AtticLobbyStone = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/BoundaryStoneSet");

            AtticBoards.SetActive(false);

            AtticBlocker.SetActive(false);

            DummyAttic.SetActive(true);

            AtticSign.SetActive(true);

            //AtticSignUI.SetActive(false);

            //AtticSignUINew.SetActive(true);

            AtticLobbyStone.SetActive(true);

            AtticBlockerInv.SetActive(false);
            AtticBlockerInv2.SetActive(false);

            StumpElevator.SetActive(false);


            TunnelToAttic.SetActive(true);

            InvTreeWood_Nohole.SetActive(false);
        }
        public static void OgMonkeyBlocksOff()
        {
            GameObject AtticBoards = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/UnityTempFile-941e523569aaac94dbfe635ec31d4a47 (combined by EdMeshCombiner)");
            GameObject AtticBlocker = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/UnityTempFile-1bf5a2ce6d8a1da49a68b9d224fbc6c0 (combined by EdMeshCombiner)");
            GameObject DummyAttic = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/DummyAttic");
            GameObject AtticBlockerInv = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/AtticBlockWithBoardsTight");
            GameObject AtticBlockerInv2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/sky jungle entrance 2");
            GameObject StumpElevator = GameObject.Find("Environment Objects/05Maze_PersistentObjects/GhostReactorElevatorManager/StumpElevator");
            GameObject StumpInside = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/UnityTempFile-96e104909c003c841a6115fd3306a3a3 (combined by EdMeshCombiner)");
            StumpInside.SetActive(true);
            GameObject TunnelToAttic = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/TunnelToAttic");
            GameObject InvTreeWood_Nohole = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/tree/TreeWood_NoHole");
            GameObject AtticSign = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/AtticSign");
            //GameObject AtticSignUI = GameObject.Find("");
            //GameObject AtticSignUINew = GameObject.Find("");
            GameObject AtticLobbyStone = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToAttic/BoundaryStoneSet");

            AtticBoards.SetActive(true);

            AtticBlocker.SetActive(true);

            DummyAttic.SetActive(false);

            AtticSign.SetActive(false);

            AtticLobbyStone.SetActive(false);

            AtticBlockerInv.SetActive(true);

            AtticBlockerInv2.SetActive(true);

            StumpElevator.SetActive(true);

            TunnelToAttic.SetActive(false);

            InvTreeWood_Nohole.SetActive(true);
        }
        */
        #endregion

        #region Ghost Reactor Lightning Mods

        #region GhostReactorLightning
        public static void GhostReactorLightning()
        {
            GameLightingManager.instance.SetCustomDynamicLightingEnabled(enable: true);
        }
        public static void GhostReactorLightningOff()
        {
            GameLightingManager.instance.SetCustomDynamicLightingEnabled(enable: false);
        }
        #endregion

        #region GhostReactorCameraLight

        public static GameLight playerLightFlashlight;
        public static void GhostReactorCameraLight()
        {
            playerLightFlashlight = GorillaTagger.Instance.mainCamera.GetComponentInChildren<GameLight>(includeInactive: true);
            playerLightFlashlight.gameObject.SetActive(value: true);
            playerLightFlashlight.range = 0.005f;
        }
        public static void GhostReactorCameraLightOff()
        {
            playerLightFlashlight.range = 10000f;
        }
        #endregion

        
        #endregion

        /*#region safe you id
        public static void SafeYourId()
        {
            FileAndFolderManager.SaveYourIdToFile();
        }
        #endregion*/
    }
}

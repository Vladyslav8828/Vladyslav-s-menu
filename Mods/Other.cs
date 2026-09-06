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

        #region GhostReactorLightsPreset broke i think ( didnt even get to finish it lol)
        //17 GameLights
        /*
        #region skghsgsfgd
        public static GameLight Preset1;
        public static GameLight Preset2;
        public static GameLight Preset3;
        public static GameLight Preset4;
        public static GameLight Preset5;
        public static GameLight Preset6;
        public static GameLight Preset7;
        public static GameLight Preset8;
        public static GameLight Preset9;
        public static GameLight Preset10;
        public static GameLight Preset11;
        public static GameLight Preset12;
        public static GameLight Preset13;
        public static GameLight Preset14;
        public static GameLight Preset15;
        public static GameLight Preset16;
        public static GameLight Preset17;

        public static void GhostReactorLightsPreset()
        {
            Preset1 = GameLightManager.CreateLight("Preset1", new Vector3(-65.57f, 13.12f, -84.54f), Color.white);
            Preset2 = GameLightManager.CreateLight("Preset2", new Vector3(-63.95f, 13.17f, -82.96f), Color.white);
            Preset3 = GameLightManager.CreateLight("Preset3", new Vector3(-66.4f, 13.16f, -85.92f), new Color(1f, 0.8f, 0.7f)); //white and a tiny it of orange
            Preset4 = GameLightManager.CreateLight("Preset4", new Vector3(-67.99f, 12.95f, -79.45f), Color.white);
            Preset5 = GameLightManager.CreateLight("Preset5", new Vector3(-62.13f, 6.98f, -62.81f), Color.white);
            Preset6 = GameLightManager.CreateLight("Preset6", new Vector3(-70.3f, 23.14f, -61.31f), Color.white);
            Preset7 = GameLightManager.CreateLight("Preset7", new Vector3(-60.82f, 15.49f, -45.19f), Color.white);
            Preset8 = GameLightManager.CreateLight("Preset8", new Vector3(-50.34f, 15.18f, -51.72f), Color.white);
            Preset9 = GameLightManager.CreateLight("Preset9", new Vector3(-47.81f, 16.08f, -65.06f), Color.white);
            Preset10 = GameLightManager.CreateLight("Preset10", new Vector3(-35.29f, 14.26f, -70.33f), Color.white);
            Preset11 = GameLightManager.CreateLight("Preset11", new Vector3(-56.51f, 10.14f, -41.61f), Color.white);
            Preset12 = GameLightManager.CreateLight("Preset12", new Vector3(-54.48f, 10.13f, -42.56f), Color.white);
            Preset13 = GameLightManager.CreateLight("Preset13", new Vector3(-33.65f, 7.62f, -53.52f), Color.white);
            Preset14 = GameLightManager.CreateLight("Preset14", new Vector3(-32.69f, 7.62f, -55.47f), Color.white);
            Preset15 = GameLightManager.CreateLight("Preset15", new Vector3(-44.54f, 7.35f, -83.27f), Color.white);
            Preset16 = GameLightManager.CreateLight("Preset16", new Vector3(-46.39f, 7.37f, -84.45f), Color.white);
            Preset17 = GameLightManager.CreateLight("Preset17", new Vector3(-43.11f, 1.98f, -55.45f), new Color(1f, 0.5f, 0f)); //orange (camp fire)
        }
        #endregion
        public static void GhostReactorLightsPresetOff()
        {
            
        }
        */
        #endregion

        #endregion
    }
}

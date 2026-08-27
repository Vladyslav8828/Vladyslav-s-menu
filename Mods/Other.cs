#nullable disable
#pragma warning disable CS0649
using GorillaTag;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using VladyslavMenu.Notifications;

namespace VladyslavMenu.Mods
{
    internal class Other
    {
        #region OgMonkeyBlocks
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
            playerLightFlashlight.range = 1000f;
        }
        #endregion

        #region GhostReactorLightsPreset
        /*17 GameLights
        private static GameLight Preset1;
        private static GameLight Preset2;
        private static GameLight Preset3;
        private static GameLight Preset4;
        private static GameLight Preset5;
        private static GameLight Preset6;
        private static GameLight Preset7;
        private static GameLight Preset8;
        private static GameLight Preset9;
        private static GameLight Preset10;
        private static GameLight Preset11;
        private static GameLight Preset12;
        private static GameLight Preset13;
        private static GameLight Preset14;
        private static GameLight Preset15;
        private static GameLight Preset16;
        private static GameLight Preset17;

        private static GameObject Preset1Object;
        private static GameObject Preset2Object;
        private static GameObject Preset3Object;
        private static GameObject Preset4Object;
        private static GameObject Preset5Object;
        private static GameObject Preset6Object;
        private static GameObject Preset7Object;
        private static GameObject Preset8Object;
        private static GameObject Preset9Object;
        private static GameObject Preset10Object;
        private static GameObject Preset11Object;
        private static GameObject Preset12Object;
        private static GameObject Preset13Object;
        private static GameObject Preset14Object;
        private static GameObject Preset15Object;
        private static GameObject Preset16Object;
        private static GameObject Preset17Object;

        public static void GhostReactorLightsPreset()
        {
            // Preset1 - White
            Preset1.gameObject.SetActive(true);
            Preset1.range = 0.005f;

            // Preset2 - White
            Preset2.gameObject.SetActive(true);
            Preset2.range = 0.005f;

            // Preset3 - White with tiny bit of orange
            Preset3.gameObject.SetActive(true);
            Preset3.range = 0.005f;

            // Preset4 - White
            Preset4.gameObject.SetActive(true);
            Preset4.range = 0.005f;

            // Preset5 - White
            Preset5.gameObject.SetActive(true);
            Preset5.range = 0.005f;

            // Preset6 - White
            Preset6.gameObject.SetActive(true);
            Preset6.range = 0.005f;

            // Preset7 - White
            Preset7.gameObject.SetActive(true);
            Preset7.range = 0.005f;

            // Preset8 - White
            Preset8.gameObject.SetActive(true);
            Preset8.range = 0.005f;

            // Preset9 - White
            Preset9.gameObject.SetActive(true);
            Preset9.range = 0.005f;

            // Preset10 - White
            Preset10.gameObject.SetActive(true);
            Preset10.range = 0.005f;

            // Preset11 - White
            Preset11.gameObject.SetActive(true);
            Preset11.range = 0.005f;

            // Preset12 - White
            Preset12.gameObject.SetActive(true);
            Preset12.range = 0.005f;

            // Preset13 - White
            Preset13.gameObject.SetActive(true);
            Preset13.range = 0.005f;

            // Preset14 - White
            Preset14.gameObject.SetActive(true);
            Preset14.range = 0.005f;

            // Preset15 - White
            Preset15.gameObject.SetActive(true);
            Preset15.range = 0.005f;

            // Preset16 - White
            Preset16.gameObject.SetActive(true);
            Preset16.range = 0.005f;

            // Preset17 - Orange (Camp Fire)
            Preset17.gameObject.SetActive(true);
            Preset17.range = 0.005f;

            Preset1Object.gameObject.SetActive(true);
            Preset1Object.transform.position = new Vector3(-65.57f, 13.12f, -84.54f);

            Preset2Object.gameObject.SetActive(true);
            Preset2Object.transform.position = new Vector3(-63.95f, 13.17f, -82.96f);

            Preset3Object.gameObject.SetActive(true);
            Preset3Object.transform.position = new Vector3(-66.4f, 13.16f, -85.92f);

            Preset4Object.gameObject.SetActive(true);
            Preset4Object.transform.position = new Vector3(-67.99f, 12.95f, -79.45f);

            Preset5Object.gameObject.SetActive(true);
            Preset5Object.transform.position = new Vector3(-62.13f, 6.98f, -62.81f);

            Preset6Object.gameObject.SetActive(true);
            Preset6Object.transform.position = new Vector3(-70.3f, 23.14f, -61.31f);

            Preset7Object.gameObject.SetActive(true);
            Preset7Object.transform.position = new Vector3(-60.82f, 15.49f, -45.19f);

            Preset8Object.gameObject.SetActive(true);
            Preset8Object.transform.position = new Vector3(-50.34f, 15.18f, -51.72f);

            Preset9Object.gameObject.SetActive(true);
            Preset9Object.transform.position = new Vector3(-47.81f, 16.08f, -65.06f);

            Preset10Object.gameObject.SetActive(true);
            Preset10Object.transform.position = new Vector3(-35.29f, 14.26f, -70.33f);

            Preset11Object.gameObject.SetActive(true);
            Preset11Object.transform.position = new Vector3(-56.51f, 10.14f, -41.61f);

            Preset12Object.gameObject.SetActive(true);
            Preset12Object.transform.position = new Vector3(-54.48f, 10.13f, -42.56f);

            Preset13Object.gameObject.SetActive(true);
            Preset13Object.transform.position = new Vector3(-33.65f, 7.62f, -53.52f);

            Preset14Object.gameObject.SetActive(true);
            Preset14Object.transform.position = new Vector3(-32.69f, 7.62f, -55.47f);

            Preset15Object.gameObject.SetActive(true);
            Preset15Object.transform.position = new Vector3(-44.54f, 7.35f, -83.27f);

            Preset16Object.gameObject.SetActive(true);
            Preset16Object.transform.position = new Vector3(-46.39f, 7.37f, -84.45f);

            Preset17Object.gameObject.SetActive(true);
            Preset17Object.transform.position = new Vector3(-43.11f, 1.98f, -55.45f);

            Preset1 = Other.Preset1Object.GetComponentInChildren<GameLight>(includeInactive: true);

            Preset1 = Preset1Object.AddComponent<GameLight>();
            Preset2 = Preset2Object.AddComponent<GameLight>();
            Preset3 = Preset3Object.AddComponent<GameLight>();
            Preset4 = Preset4Object.AddComponent<GameLight>();
            Preset5 = Preset5Object.AddComponent<GameLight>();
            Preset6 = Preset6Object.AddComponent<GameLight>();
            Preset7 = Preset7Object.AddComponent<GameLight>();
            Preset8 = Preset8Object.AddComponent<GameLight>();
            Preset9 = Preset9Object.AddComponent<GameLight>();
            Preset10 = Preset10Object.AddComponent<GameLight>();
            Preset11 = Preset11Object.AddComponent<GameLight>();
            Preset12 = Preset12Object.AddComponent<GameLight>();
            Preset13 = Preset13Object.AddComponent<GameLight>();
            Preset14 = Preset14Object.AddComponent<GameLight>();
            Preset15 = Preset15Object.AddComponent<GameLight>();
            Preset16 = Preset16Object.AddComponent<GameLight>();
            Preset17 = Preset17Object.AddComponent<GameLight>();

            Preset1 = Other.Preset1Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset2 = Other.Preset2Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset3 = Other.Preset3Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset4 = Other.Preset4Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset5 = Other.Preset5Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset6 = Other.Preset6Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset7 = Other.Preset7Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset8 = Other.Preset8Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset9 = Other.Preset9Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset10 = Other.Preset10Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset11 = Other.Preset11Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset12 = Other.Preset12Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset13 = Other.Preset13Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset14 = Other.Preset14Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset15 = Other.Preset15Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset16 = Other.Preset16Object.GetComponentInChildren<GameLight>(includeInactive: true);
            Preset17 = Other.Preset17Object.GetComponentInChildren<GameLight>(includeInactive: true);
        }
        public static void GhostReactorLightsPresetOff()
        {
            // Preset1 - White
            Preset1.gameObject.SetActive(true);
            Preset1.range = 1000f;

            // Preset2 - White
            Preset2.gameObject.SetActive(true);
            Preset2.range = 1000f;

            // Preset3 - White with tiny bit of orange
            Preset3.gameObject.SetActive(true);
            Preset3.range = 1000f;

            // Preset4 - White
            Preset4.gameObject.SetActive(true);
            Preset4.range = 1000f;

            // Preset5 - White
            Preset5.gameObject.SetActive(true);
            Preset5.range = 1000f;

            // Preset6 - White
            Preset6.gameObject.SetActive(true);
            Preset6.range = 1000f;

            // Preset7 - White
            Preset7.gameObject.SetActive(true);
            Preset7.range = 1000f;

            // Preset8 - White
            Preset8.gameObject.SetActive(true);
            Preset8.range = 1000f;

            // Preset9 - White
            Preset9.gameObject.SetActive(true);
            Preset9.range = 1000f;

            // Preset10 - White
            Preset10.gameObject.SetActive(true);
            Preset10.range = 1000f;

            // Preset11 - White
            Preset11.gameObject.SetActive(true);
            Preset11.range = 1000f;

            // Preset12 - White
            Preset12.gameObject.SetActive(true);
            Preset12.range = 1000f;

            // Preset13 - White
            Preset13.gameObject.SetActive(true);
            Preset13.range = 1000f;

            // Preset14 - White
            Preset14.gameObject.SetActive(true);
            Preset14.range = 1000f;

            // Preset15 - White
            Preset15.gameObject.SetActive(true);
            Preset15.range = 1000f;

            // Preset16 - White
            Preset16.gameObject.SetActive(true);
            Preset16.range = 1000f;

            // Preset17 - Orange (Camp Fire)
            Preset17.gameObject.SetActive(true);
            Preset17.range = 1000f;
        }
        */
        #endregion

        #endregion
    }
}

using GorillaLocomotion;
using GorillaTag;
using Meta.WitAi;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.XR;
using Valve.VR.InteractionSystem;
using VladyslavMenu.Classes;
using VladyslavMenu.Menu;
using static VladyslavMenu.Menu.Main;

namespace VladyslavMenu.Mods
{
    public class Guns
    {
        #region TeleportGun
        public static bool previousTeleportTrigger;
        public static void TeleportGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                var GunData = RenderGun();
                GameObject NewPointer = GunData.NewPointer;

                if (ControllerInputPoller.TriggerFloat(XRNode.RightHand) > 0.5f && !previousTeleportTrigger)
                {
                    GTPlayer.Instance.TeleportTo(NewPointer.transform.position + Vector3.up, GTPlayer.Instance.transform.rotation, keepVelocity: false, center: true);
                    GorillaTagger.Instance.rigidbody.linearVelocity = Vector3.zero;
                }

                previousTeleportTrigger = ControllerInputPoller.TriggerFloat(XRNode.RightHand) > 0.5f;
            }
            else
            {
                var gunData = RenderGun();
                Object.Destroy(gunData.NewPointer);
                Object.Destroy(GameObject.Find("VladyslavMenu_GunLine"));
            }
        }
        #endregion

        #region LightGun
        
        public static bool previousLightTrigger;

        public static GameLight GunLight_VladyslavMenu;
        public static void LightGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                var GunData = RenderGun();
                GameObject NewPointer = GunData.NewPointer;

                if (ControllerInputPoller.TriggerFloat(XRNode.RightHand) > 0.5f && !previousLightTrigger)
                {
                    GunLight_VladyslavMenu = NewPointer.GetComponentInChildren<GameLight>(includeInactive: true);
                    GunLight_VladyslavMenu.gameObject.SetActive(value: true);
                    GunLight_VladyslavMenu.range = 0.005f;

                }
                previousLightTrigger = ControllerInputPoller.TriggerFloat(XRNode.RightHand) > 0.5f;
            }
            else 
            {
                var gunData = RenderGun();
                Object.Destroy(gunData.NewPointer);
                Object.Destroy(GameObject.Find("VladyslavMenu_GunLine"));

                GunLight_VladyslavMenu.range = 0f;
            }
        }
        
        #endregion
        // the light gun is wip (broken)
    }
}
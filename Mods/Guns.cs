using GorillaLocomotion;
using GorillaTag;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.XR;
using Valve.VR.InteractionSystem;
using VladyslavMenu.Classes;
using static VladyslavMenu.Menu.Main;

namespace VladyslavMenu.Mods
{
    public class Guns
    {
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
                Object.Destroy(GameObject.Find("iiMenu_GunLine"));
            }
        }
    }
}

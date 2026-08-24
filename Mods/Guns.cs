using GorillaLocomotion;
using VladyslavMenu.Classes;
using UnityEngine;
using UnityEngine.XR;
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
                //GameObject line = new GameObject("iiMenu_GunLine");

                if (ControllerInputPoller.TriggerFloat(XRNode.RightHand) > 0.5f && !previousTeleportTrigger)
                {
                    GTPlayer.Instance.TeleportTo(NewPointer.transform.position + Vector3.up, GTPlayer.Instance.transform.rotation);
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

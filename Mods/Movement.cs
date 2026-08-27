using GorillaLocomotion;
using VladyslavMenu.Classes;
using UnityEngine;
using UnityEngine.XR;
using static VladyslavMenu.Menu.Main;

namespace VladyslavMenu.Mods
{
    public class Movement
    {
        #region Fly
        public static void Fly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * 0.1f;
                GorillaTagger.Instance.rigidbody.linearVelocity = Vector3.zero;
            }
        }
        #endregion

        #region Platforms
        public static GameObject platl;
        public static GameObject platr;

        public static void Platforms()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (platl == null)
                {
                    platl = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platl.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    platl.transform.position = new Vector3(TrueLeftHand().position.x, TrueLeftHand().position.y - 0.075f, TrueLeftHand().position.z);
                    platl.transform.rotation = TrueLeftHand().rotation;

                    FixStickyColliders(platl);

                    ColorChanger colorChanger = platl.AddComponent<ColorChanger>();
                    colorChanger.colors = VladyslavMenu.Settings.backgroundColor;
                }
            }
            else
            {
                if (platl != null)
                {
                    Object.Destroy(platl);
                    platl = null;
                }
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (platr == null)
                {
                    platr = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platr.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    platr.transform.position = new Vector3(TrueRightHand().position.x, TrueRightHand().position.y - 0.075f, TrueRightHand().position.z);
                    platr.transform.rotation = TrueRightHand().rotation;

                    FixStickyColliders(platr);

                    ColorChanger colorChanger = platr.AddComponent<ColorChanger>();
                    colorChanger.colors = VladyslavMenu.Settings.backgroundColor;
                }
            }
            else
            {
                if (platr != null)
                {
                    Object.Destroy(platr);
                    platr = null;
                }
            }
        }
        #endregion
    }
}

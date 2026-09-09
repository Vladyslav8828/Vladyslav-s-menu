using GorillaLocomotion;
using VladyslavMenu.Classes;
using UnityEngine;
using UnityEngine.XR;
using static VladyslavMenu.Menu.Main;
using UnityEngine.InputSystem;
using VladyslavMenu.Managers;
using GorillaExtensions;
using Voxels;
using ExitGames.Client.Photon.StructWrapping;

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

        #region Slower Fly
        public static void SlowerFly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * 0.05f;
                GorillaTagger.Instance.rigidbody.linearVelocity = Vector3.zero;
            }
        }
        #endregion

        #region Faster Fly
        public static void FasterFly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * 0.2f;
                GorillaTagger.Instance.rigidbody.linearVelocity = Vector3.zero;
            }
        }
        #endregion

        #region Add Velocity forward
        public static void AddVelocityForward()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * 0.1f;
            }
        }
        #endregion

        #region joystick fly
        public static void joystickFly()
        {
            var leftJoystick = JoystickManager.leftJoystick;
            var rightJoystick = JoystickManager.rightJoystick;

            Vector3 LJDirection = (GTPlayer.Instance.bodyCollider.transform.forward * leftJoystick.y) + (GTPlayer.Instance.bodyCollider.transform.right * leftJoystick.x);
            Vector3 RJdirection = Vector3.up * rightJoystick.y;

            GTPlayer.Instance.transform.position += LJDirection / 4f; //the up and down shit
            GTPlayer.Instance.transform.position += RJdirection / 4f; //the side to side shit
            GorillaTagger.Instance.rigidbody.linearVelocity = Vector3.zero;
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

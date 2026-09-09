using VladyslavMenu.Menu;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine;
using Valve.VR;
using VladyslavMenu.Classes;
using Valve.VR.Extras;

namespace VladyslavMenu.Managers
{
    public class JoystickManager
    {
        public static Vector2 leftJoystick = Vector2.zero;
        public static bool leftJoystickClick;

        public static Vector2 rightJoystick = Vector2.zero;
        public static bool rightJoystickClick;

        public static void Update()
        {
            leftJoystick = SteamVR_Actions.gorillaTag_LeftJoystick2DAxis.GetAxis(SteamVR_Input_Sources.LeftHand);
            rightJoystick = SteamVR_Actions.gorillaTag_RightJoystick2DAxis.GetAxis(SteamVR_Input_Sources.RightHand);

            leftJoystickClick = SteamVR_Actions.gorillaTag_LeftJoystickClick.GetState(SteamVR_Input_Sources.LeftHand);
            rightJoystickClick = SteamVR_Actions.gorillaTag_RightJoystickClick.GetState(SteamVR_Input_Sources.RightHand);
        }
    }
}
using UnityEngine.UI;
using VladyslavMenu.Classes;
using VladyslavMenu.Mods;
using static VladyslavMenu.Menu.Main;
using static VladyslavMenu.Settings;

namespace VladyslavMenu.Menu
{
    public class Buttons
    {
        /*
         * Here is where all of your buttons are located.
         * To create a button, you may use the following code:
         * 
         * Move to Category:
         *   new ButtonInfo { buttonText = "Settings", method =() => currentCategory = 1, isTogglable = false, toolTip = "Opens the main settings page for the menu."},
         *   new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},
         * 
         * Togglable Mod:
         *   new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), toolTip = "Spawns platforms on your hands when pressing grip."},
         */

        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods [0]
                new ButtonInfo { buttonText = "Settings", method =() => currentCategory = 1, isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Room Mods", method =() => currentCategory = 4, isTogglable = false, toolTip = "Opens the room mods tab."},
                new ButtonInfo { buttonText = "Movement Mods", method =() => currentCategory = 5, isTogglable = false, toolTip = "Opens the movement mods tab."},
                new ButtonInfo { buttonText = "Safety", method =() => currentCategory = 6, isTogglable = false, toolTip = "Opens the safety mods tab."},
                new ButtonInfo { buttonText = "Guns", method =() => currentCategory = 7, isTogglable = false, toolTip = "Opens the Guns tab."},
                new ButtonInfo { buttonText = "Other", method =() => currentCategory = 8, isTogglable = false, toolTip = "Opens the Other tab."},
            },

            new ButtonInfo[] { // Settings [1]
                new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => currentCategory = 2, isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => currentCategory = 3, isTogglable = false, toolTip = "Opens the movement settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings [2]
                new ButtonInfo { buttonText = "Return to Settings", method =() => currentCategory = 1, isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => rightHanded = true, disableMethod =() => rightHanded = false, toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => disableNotifications = false, disableMethod =() => disableNotifications = true, enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => fpsCounter = true, disableMethod =() => fpsCounter = false, enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => disconnectButton = true, disableMethod =() => disconnectButton = false, enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                new ButtonInfo { buttonText = "Disable Outlines", enableMethod =() => MenuOutline = false, disableMethod =() => MenuOutline = true, toolTip = "Toggles the menu outline."},
            },

            new ButtonInfo[] { // Movement Settings [3]
                new ButtonInfo { buttonText = "Return to Settings", method =() => currentCategory = 1, isTogglable = false, toolTip = "Returns to the main settings page for the menu."},

                new ButtonInfo { buttonText = "idk",toolTip = "this is usless"},
            },

            new ButtonInfo[] { // Room Mods [4]
                new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "Disconnect", method =() => NetworkSystem.Instance.ReturnToSinglePlayer(), isTogglable = false, toolTip = "Disconnects you from the room."},
            },

            new ButtonInfo[] { // Movement Mods [5]
                new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), toolTip = "Spawns platforms on your hands when pressing grip."},

                new ButtonInfo { buttonText = "Fly", method =() => Movement.Fly(), toolTip = "Sends you forward when holding A."},
            },

            new ButtonInfo[] { // Safety [6]
                new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "Anti-Report <color=grey>[</color><color=green>Disconnect</color><color=grey>]</color>", method =() => Safety.AntiReportDisconnect(), toolTip = "Disconnects you from the room if you are reported."},
            },

            new ButtonInfo[] { // Guns [7]
                new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "Teleport Gun", method =() => Guns.TeleportGun(), toolTip = "Teleports you to where you point."},
                //new ButtonInfo { buttonText = "Light Gun <color=grey>[</color><color=green>Ghost Reactor Lightning</color><color=grey>]</color> <color=grey>[</color><color=green>CS</color><color=grey>]</color>", method =() => Guns.LightGun(), toolTip = "Spawns a light on your gun."},
            },

            new ButtonInfo[] { // Other [8]
                new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "Attic <color=grey>[</color><color=green>CS</color><color=grey>]</color>",  enableMethod =() => Other.OgMonkeyBlocksOn(), disableMethod =() => Other.OgMonkeyBlocksOff(),toolTip = "Trys to bring back the attic for the old days"},
                new ButtonInfo { buttonText = "Ghost Reactor Lightning <color=grey>[</color><color=green>CS</color><color=grey>]</color>", enableMethod =() => Other.GhostReactorLightning(), disableMethod =() => Other.GhostReactorLightningOff(),toolTip = "Toggles the ghost reactor lightning."},
                new ButtonInfo { buttonText = "FlashLight <color=grey>[</color><color=green>Ghost Reactor Lightning</color><color=grey>]</color> <color=grey>[</color><color=green>CS</color><color=grey>]</color>", enableMethod =() => Other.GhostReactorCameraLight(), disableMethod =() => Other.GhostReactorCameraLightOff(),toolTip = "Spawns a light on your head."},
                //new ButtonInfo { buttonText = "Lights Preset <color=grey>[</color><color=green>Ghost Reactor Lightning</color><color=grey>]</color> <color=grey>[</color><color=green>CS</color><color=grey>]</color>", enableMethod =() => Other.GhostReactorLightsPreset(), disableMethod =() => Other.GhostReactorLightsPresetOff(),toolTip = "Spawns a light on your hand."},
            },
        };
    }
}

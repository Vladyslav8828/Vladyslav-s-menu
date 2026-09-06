using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace VladyslavMenu.Managers
{
    internal class GameLightManager
    {
        public static GameLight CreateLight(string name, Vector3 position, Color color)
        {
            // Create GameObject
            GameObject obj = new GameObject(name);
            obj.transform.position = position;

            // Add Unity Light
            Light unityLight = obj.AddComponent<Light>();
            unityLight.type = LightType.Point;
            unityLight.range = 1f;
            unityLight.intensity = 1f;
            unityLight.color = color;
            unityLight.shadows = LightShadows.None;

            // Add GameLight
            GameLight gameLight = obj.AddComponent<GameLight>();
            gameLight.light = unityLight;
            gameLight.applyRange = true;
            gameLight.cachedPosition = position;

            // Register with the game's lighting system
            if (GameLightingManager.instance != null)
            {
                gameLight.lightId = GameLightingManager.instance.AddGameLight(gameLight);
                Debug.Log($"{name} registered with ID: {gameLight.lightId}");
            }
            else
            {
                Debug.LogError($"{name} failed to register - GameLightingManager is null!");
            }

            obj.SetActive(true);
            return gameLight;
        }
        public static void DestroyLight(string name) 
        {
            GameObject.Destroy(GameObject.Find("name"));
        }
    }
}

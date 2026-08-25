using GorillaGameModes;
using GorillaTagScripts;
using Photon.Pun;
using VladyslavMenu.Menu;
using VladyslavMenu.Mods;
using VladyslavMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static VladyslavMenu.Menu.Main;

namespace VladyslavMenu.Classes
{
    public static class VRRigExtensions
    {
        public static bool Active(this VRRig rig) =>
            rig != null && ActiveRigs.Contains(rig);

        private static int _lastFrame = -1;
        private static readonly List<VRRig> _rigs = new List<VRRig>();
        private static readonly object _lock = new object();
        public static HashSet<VRRig> Blocked = new HashSet<VRRig>();

        public static List<VRRig> ActiveRigs
        {
            get
            {
                int frame = Time.frameCount;
                if (frame == _lastFrame)
                    return _rigs;

                lock (_lock)
                {
                    if (frame == _lastFrame)
                        return _rigs;

                    _lastFrame = frame;
                    _rigs.Clear();

                    foreach (var rig in VRRigCache.ActiveRigs)
                    {
                        if (rig != null && !Blocked.Contains(rig)) //!Settings.Blocked.Contains(rig))
                            _rigs.Add(rig);
                    }
                }

                return _rigs;
            }

        }
    }
}
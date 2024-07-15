using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.Inventory
{
    [Serializable]
    public class FarmToolData
    {
        public string Name;
        public int Price;
        [HideInInspector] public int Level;
        [HideInInspector] public bool IsUnlocked;
        public ToolView FarmToolViewPrefab;
        public Sprite Image;
    }
}
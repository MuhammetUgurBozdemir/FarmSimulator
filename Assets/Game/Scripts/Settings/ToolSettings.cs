using System.Collections.Generic;
using Game.Scripts.Inventory;
using UnityEngine;

namespace Game.Scripts.Settings
{
    [CreateAssetMenu(fileName = nameof(ToolSettings), menuName = nameof(ToolSettings))]
    public class ToolSettings : ScriptableObject
    {
        public List<FarmToolData> farmTools;
    }
}
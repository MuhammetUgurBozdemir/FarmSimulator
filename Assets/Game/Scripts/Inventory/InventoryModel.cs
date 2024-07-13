using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Scripts.Inventory
{
    public class InventoryModel
    {
        private List<FarmToolData> tools;

        public FarmToolData GetTool(FarmToolData farmToolData) => tools.Find(x => x.Name == farmToolData.Name);

        public void AddTool(FarmToolData farmToolData)
        {
            tools.Add(farmToolData);
        }
    }
}


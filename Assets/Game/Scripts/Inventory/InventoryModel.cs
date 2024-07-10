using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Scripts.Inventory
{
    public class InventoryModel
    {
        private List<FarmTool> tools;

        public FarmTool GetTool(FarmTool farmTool) => tools.Find(x => x.Name == farmTool.Name);

        public void AddTool(FarmTool farmTool)
        {
            tools.Add(farmTool);
        }
    }
}


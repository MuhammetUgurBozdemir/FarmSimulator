using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Scripts.Inventory
{
    public class InventoryModel
    {
        private List<Tool> tools;

        public Tool GetTool(Tool tool) => tools.Find(x => x.Name == tool.Name);

        public void AddTool(Tool tool)
        {
            tools.Add(tool);
        }
    }
}


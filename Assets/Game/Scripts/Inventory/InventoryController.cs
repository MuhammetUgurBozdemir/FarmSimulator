using System.Collections.Generic;
using Game.Scripts.Controllers;

namespace Game.Scripts.Inventory
{
    public class InventoryController
    {
        public List<FarmToolData> ownedTools = new List<FarmToolData>();
        public int LoadAmount;


        #region Injection

        private ScreenController _screenController;

        public InventoryController(ScreenController screenController)
        {
            _screenController = screenController;
        }

        #endregion

        public void Load()
        {
            LoadAmount += 9;
            _screenController.GameView.UpdateLoadAmount(LoadAmount);
        }

        public void Unload()
        {
            LoadAmount = 0;
            _screenController.GameView.UpdateLoadAmount(LoadAmount);
        }
    }
}
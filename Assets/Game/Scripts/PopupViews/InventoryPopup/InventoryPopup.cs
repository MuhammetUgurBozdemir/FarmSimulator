using System.Collections.Generic;
using Game.Scripts.Inventory;
using Game.Scripts.Player;
using Game.Scripts.Popup;
using Game.Scripts.Settings;
using UnityEngine;
using Zenject;

namespace Game.Scripts.PopupViews
{
    public class InventoryPopup : PopupView
    {
      
        private List<InventoryItemView> items = new List<InventoryItemView>();
        [SerializeField] private InventoryItemView itemViewPrefab;
        [SerializeField] private Transform contentHolder;
        
        private DiContainer _diContainer;
        private ToolSettings _toolSettings;
        private InventoryController _inventoryController;
        private PlayerController _playerController;

        [Inject]
        private void Construct(DiContainer diContainer, ToolSettings toolSettings,
            InventoryController inventoryController,
            PlayerController playerController)
        {
            _diContainer = diContainer;
            _toolSettings = toolSettings;
            _inventoryController = inventoryController;
            _playerController = playerController;
        }


        public override void ShowPopup()
        {
            base.ShowPopup();

            ListItem();
        }

        private void ListItem()
        {
            foreach (FarmToolData toolSettingsFarmTool in _inventoryController.ownedTools)
            {
                if(_playerController.IsEquipped(toolSettingsFarmTool)) continue;
                
                var item = _diContainer.InstantiatePrefabForComponent<InventoryItemView>(itemViewPrefab);
                item.transform.SetParent(contentHolder);
                item.Init(toolSettingsFarmTool, RemoveSelectedItem);
                items.Add(item);
            }
        }

        private void RemoveSelectedItem(InventoryItemView item)
        {
            for (var i = items.Count - 1; i >= 0; i--)
            {
                items[i].DestroyView();
            }

            items.Clear();

            ListItem();
        }
    }
}
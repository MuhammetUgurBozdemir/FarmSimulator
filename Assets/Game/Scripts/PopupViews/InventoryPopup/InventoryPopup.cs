using System.Collections.Generic;
using Game.Scripts.Inventory;
using Game.Scripts.Popup;
using Game.Scripts.Settings;
using UnityEngine;
using Zenject;

namespace Game.Scripts.PopupViews
{
    public class InventoryPopup : PopupView
    {
        private DiContainer _diContainer;
        private ToolSettings _toolSettings;
        private InventoryController _inventoryController;
        private List<InventoryItemView> items = new List<InventoryItemView>();
        [SerializeField] private InventoryItemView itemViewPrefab;
        [SerializeField] private Transform contentHolder;

        [Inject]
        private void Construct(DiContainer diContainer, ToolSettings toolSettings,
            InventoryController inventoryController)
        {
            _diContainer = diContainer;
            _toolSettings = toolSettings;
            _inventoryController = inventoryController;
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
                var item = _diContainer.InstantiatePrefabForComponent<InventoryItemView>(itemViewPrefab);
                item.transform.SetParent(contentHolder);
                item.Init(toolSettingsFarmTool, RemoveSelectedItem);
                items.Add(item);
            }
        }

        private void RemoveSelectedItem(InventoryItemView item)
        {
            items.Remove(item);
            item.DestroyView();
        }
    }
}
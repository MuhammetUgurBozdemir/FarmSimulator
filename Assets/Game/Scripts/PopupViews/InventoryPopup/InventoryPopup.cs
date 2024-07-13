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
        private List<InventoryPopupItemView> items = new List<InventoryPopupItemView>();
        [SerializeField] private InventoryPopupItemView itemViewPrefab;
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
            ClearList();
            
            foreach (FarmToolData toolSettingsFarmTool in _toolSettings.farmTools)
            {
                if (_inventoryController.ownedTools.Contains(toolSettingsFarmTool)) continue;

                var item = _diContainer.InstantiatePrefabForComponent<InventoryPopupItemView>(itemViewPrefab);
                item.transform.SetParent(contentHolder);
                item.Init(toolSettingsFarmTool,ListItem);
                items.Add(item);
            }
        }

        private void ClearList()
        {
            for (var i = items.Count - 1; i >= 0; i--)
            {
                items[i].DestroyView();
            }
            
            items.Clear();
        }
    }
}
using System.Collections.Generic;
using Game.Scripts.Controllers;
using Game.Scripts.Inventory;
using Game.Scripts.Popup;
using Game.Scripts.Settings;
using TMPro;
using UnityEngine;
using Zenject;

namespace Game.Scripts.PopupViews
{
    public class MarketPopup : PopupView
    {
        private List<MarketPopupItemView> items = new List<MarketPopupItemView>();
        [SerializeField] private MarketPopupItemView itemViewPrefab;
        [SerializeField] private Transform contentHolder;
        [SerializeField] private TextMeshProUGUI loadAmount;
        
        private DiContainer _diContainer;
        private ToolSettings _toolSettings;
        private InventoryController _inventoryController;
        private CurrencyController _currencyController;

        [Inject]
        private void Construct(DiContainer diContainer, ToolSettings toolSettings,
            InventoryController inventoryController,CurrencyController currencyController)
        {
            _diContainer = diContainer;
            _toolSettings = toolSettings;
            _inventoryController = inventoryController;
            _currencyController = currencyController;
        }


        public override void ShowPopup()
        {
            base.ShowPopup();

            ListItem();

            loadAmount.text ="Load Amount: "+ _inventoryController.LoadAmount;
        }

        private void ListItem()
        {
            foreach (FarmToolData toolSettingsFarmTool in _toolSettings.farmTools)
            {
                if (_inventoryController.ownedTools.Contains(toolSettingsFarmTool)) continue;

                var item = _diContainer.InstantiatePrefabForComponent<MarketPopupItemView>(itemViewPrefab);
                item.transform.SetParent(contentHolder);
                item.Init(toolSettingsFarmTool, RemoveSelectedItem);
                items.Add(item);
            }
        }

        public void SellButton()
        {
            _currencyController.UpdateCoinAmount(_inventoryController.LoadAmount);
            _inventoryController.Unload();
            loadAmount.text ="Load Amount: "+ _inventoryController.LoadAmount;
        }

        private void RemoveSelectedItem(MarketPopupItemView item)
        {
            items.Remove(item);
            item.DestroyView();
        }
    }
}
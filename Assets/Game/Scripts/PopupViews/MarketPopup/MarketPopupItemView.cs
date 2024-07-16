using System;
using Game.Scripts.Controllers;
using Game.Scripts.Inventory;
using Game.Scripts.Settings;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.PopupViews
{
    public class MarketPopupItemView : MonoBehaviour
    {
        [SerializeField] private Image sprite;
        [SerializeField] private TextMeshProUGUI priceText;
        private Action<MarketPopupItemView> _clickAction;
        private FarmToolData _data;


        private InventoryController _inventoryController;
        private CurrencyController _currencyController;

        [Inject]
        private void Construct(InventoryController inventoryController,CurrencyController currencyController)
        {
            _inventoryController = inventoryController;
            _currencyController = currencyController;
        }
        public void Init(FarmToolData data , Action<MarketPopupItemView> clickAction)
        {
            sprite.sprite = data.Image;
            priceText.text = data.Price.ToString();
            _clickAction = clickAction;
            _data = data;
        }

        public void OnClick()
        {
            _inventoryController.ownedTools.Add(_data);
            _clickAction?.Invoke(this);
        }

        public void DestroyView()
        {
            Destroy(gameObject);
        }
    }
}
using System;
using Game.Scripts.Controllers;
using Game.Scripts.Inventory;
using Game.Scripts.Player;
using Game.Scripts.Settings;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.PopupViews
{
    public class InventoryItemView : MonoBehaviour
    {
        [SerializeField] private Image sprite;
        [SerializeField] private TextMeshProUGUI priceText;
        private Action<InventoryItemView> _clickAction;
        private FarmToolData _data;
        [SerializeField] private TextMeshProUGUI infoText;

        private InventoryController _inventoryController;
        private PlayerController _playerController;
        private CurrencyController _currencyController;

        [Inject]
        private void Construct(InventoryController inventoryController, PlayerController playerController,
            CurrencyController currencyController)
        {
            _inventoryController = inventoryController;
            _playerController = playerController;
            _currencyController = currencyController;
        }

        public void Init(FarmToolData data, Action<InventoryItemView> clickAction)
        {
            sprite.sprite = data.Image;
            _clickAction = clickAction;
            _data = data;

            infoText.text = _data.ProcessTime + " Seconds Harvest Time";

        }

        public void OnClick()
        {
            _playerController.EquipItem(_data);
            _clickAction?.Invoke(this);
        }

        public void DestroyView()
        {
            Destroy(gameObject);
        }
    }
}
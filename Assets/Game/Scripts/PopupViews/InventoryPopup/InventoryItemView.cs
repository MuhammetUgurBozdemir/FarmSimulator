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

        private InventoryController _inventoryController;
        private PlayerController _playerController;

        [Inject]
        private void Construct(InventoryController inventoryController,PlayerController playerController)
        {
            _inventoryController = inventoryController;
            _playerController = playerController;
        }

        public void Init(FarmToolData data, Action<InventoryItemView> clickAction)
        {
            sprite.sprite = data.Image;
            priceText.text = data.Price.ToString();
            _clickAction = clickAction;
            _data = data;
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
using System;
using Game.Scripts.Inventory;
using Game.Scripts.Settings;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.PopupViews
{
    public class InventoryPopupItemView : MonoBehaviour
    {
        [SerializeField] private Image sprite;
        [SerializeField] private TextMeshProUGUI priceText;
        private Action _clickAction;
        private FarmToolData _data;

        private InventoryController _inventoryController;

        [Inject]
        private void Construct(
            InventoryController inventoryController)
        {
            _inventoryController = inventoryController;
        }
        public void Init(FarmToolData data , Action clickAction)
        {
            sprite.sprite = data.Image;
            priceText.text = data.Price.ToString();
            _clickAction = clickAction;
            _data = data;
        }

        public void OnClick()
        {
            _inventoryController.ownedTools.Add(_data);
            _clickAction?.Invoke();
        }

        public void DestroyView()
        {
            Destroy(gameObject);
        }
    }
}
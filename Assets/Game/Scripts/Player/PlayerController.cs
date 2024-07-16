using System;
using Game.Scripts.Controllers;
using Game.Scripts.Enum;
using Game.Scripts.Inventory;
using Game.Scripts.Settings;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Player
{
    public class PlayerController : IInitializable, IDisposable
    {
        private PlayerMovement playerMovement;
        private Transform ToolHolder;
        private ToolView _equippedItem;
        private FarmToolData _equippedItemData;

        public FarmToolData GetItemData => _equippedItemData;
        

        #region Injection

        private DiContainer _diContainer;
        private PrefabSettings _prefabSettings;
        private InventoryController _inventoryController;
        private ScreenController _screenController;

        public PlayerController(DiContainer diContainer,
            PrefabSettings prefabSettings,
            InventoryController inventoryController,
            ScreenController screenController)
        {
            _diContainer = diContainer;
            _prefabSettings = prefabSettings;
            _inventoryController = inventoryController;
            _screenController = screenController;
        }

        #endregion

        public void Initialize()
        {
            _screenController.ChangeState(ScreenState.MainMenuView);
            
            playerMovement = _diContainer.InstantiatePrefabForComponent<PlayerMovement>(_prefabSettings.playerMovement);
            playerMovement.Init();
        }
        public void EquipItem(FarmToolData data)
        {
            if (_equippedItemData != null)
            {
                _equippedItem.DestroyView();
            }
            
            _equippedItem = _diContainer.InstantiatePrefabForComponent<ToolView>(data.FarmToolViewPrefab,playerMovement.toolHolder);
            _equippedItemData = data;
        }

        public bool IsEquipped(FarmToolData data)
        {
            return data == _equippedItemData;
        }
        public void Dispose()
        {
            playerMovement.Dispose();
        }
    }
}
using System;
using Game.Scripts.Controllers.Player;
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

        public PlayerController(DiContainer diContainer,
            PrefabSettings prefabSettings,
            InventoryController inventoryController)
        {
            _diContainer = diContainer;
            _prefabSettings = prefabSettings;
            _inventoryController = inventoryController;
        }

        #endregion

        public void Initialize()
        {
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
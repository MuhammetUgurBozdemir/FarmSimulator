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
        private GameObject _equippedItem;

        #region Injection

        private DiContainer _diContainer;
        private PrefabSettings _prefabSettings;

        public PlayerController(DiContainer diContainer,
            PrefabSettings prefabSettings)
        {
            _diContainer = diContainer;
            _prefabSettings = prefabSettings;
        }

        #endregion

        public void Initialize()
        {
            playerMovement = _diContainer.InstantiatePrefabForComponent<PlayerMovement>(_prefabSettings.playerMovement);
            playerMovement.Init();
        }
        public void EquipItem(FarmToolData data)
        {
            _equippedItem = _diContainer.InstantiatePrefab(data.FarmToolPrefab,playerMovement.toolHolder);
        }

        public void Dispose()
        {
            playerMovement.Dispose();
        }
    }
}
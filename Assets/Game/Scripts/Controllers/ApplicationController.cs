using System;
using Game.Scripts.Controllers.Player;
using Zenject;

namespace Game.Scripts.Controllers
{
    public class ApplicationController : IInitializable, IDisposable
    {
        private PlayerMovement playerMovement;
        
        #region Injection

        private DiContainer _diContainer;
        private PrefabSettings _prefabSettings;

        public ApplicationController( DiContainer diContainer,
            PrefabSettings prefabSettings)
        {
            _diContainer = diContainer;
            _prefabSettings = prefabSettings;
        }

        #endregion
        
        public void Initialize()
        {
            playerMovement =_diContainer.InstantiatePrefabForComponent<PlayerMovement>(_prefabSettings.playerMovement);
            playerMovement.Init();
        }

        public void Dispose()
        {
            playerMovement.Dispose();
        }
    }
}
using Game.Scripts.Controllers;
using Game.Scripts.Inventory;
using Game.Scripts.Player;
using Game.Scripts.Popup;
using Game.Scripts.Settings;
using Nevermind.CriminalWords.Installer;
using Zenject;

namespace Game.Scripts.Initializers
{
    public class GameSceneInstaller : MonoInstaller
    {
        #region Injection

        private PrefabSettings _prefabSettings;

        [Inject]
        private void Construct(PrefabSettings prefabSetting)
        {
            _prefabSettings = prefabSetting;
        }

        #endregion

        public override void InstallBindings()
        {
            GameSignalsInstaller.Install(Container);

            Container.BindInterfacesAndSelfTo<PlayerController>().AsSingle();

            Container.Bind<PopupController>().AsSingle();
            Container.Bind<InventoryController>().AsSingle();
            Container.Bind<CurrencyController>().AsSingle();
        }
    }
}
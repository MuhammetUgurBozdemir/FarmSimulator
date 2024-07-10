using Game.Scripts.Controllers;
using Game.Scripts.Popup;
using Zenject;

namespace Game.Scripts.Initializers
{
    public class GameSceneInstaller : MonoInstaller
    {
        #region Injection

        private PrefabSettings _prefabSettings;

        [Inject]
        private void Construct(PrefabSettings prefabSetting
        )
        {
            _prefabSettings = prefabSetting;
        }

        #endregion

        public override void InstallBindings()
        {
            //signal install
            // GameSignalsInstaller.Install(Container);

            Container.BindInterfacesAndSelfTo<ApplicationController>().AsSingle();
            
            Container.Bind<PopupController>().AsSingle();
        }
    }
}
using System.Collections.Generic;
using Game.Scripts.Settings;
using Zenject;

namespace Game.Scripts.Popup
{
    public class PopupController
    {
        private List<PopupView> popups=new List<PopupView>();

        private PopupSettings _popupSettings;
        private DiContainer _diContainer;

        [Inject]
        private void Construct(PopupSettings popupSettings, DiContainer diContainer)
        {
            _popupSettings = popupSettings;
            _diContainer = diContainer;
        }

        public void PopupRequest(string popupname , PopupParameters parameters)
        {
            var popup = _diContainer.InstantiatePrefabForComponent<PopupView>(_popupSettings.GetPopup(popupname));
            popups.Add(popup);
            
            popup.Init(parameters);
        }
    }
}
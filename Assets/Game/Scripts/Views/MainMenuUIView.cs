using Game.Scripts.Controllers;
using Game.Scripts.Enum;
using Game.Scripts.Player;
using Game.Scripts.Popup;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Views
{
    public class MainMenuUIView : BaseScreen
    {
        private ScreenController _screenController;
        private PopupController _popupController;
        private PlayerController _playerController;

        [Inject]
        private void Construct(PopupController popupController,
            PlayerController playerController,
            ScreenController screenController)
        {
            _popupController = popupController;
            _playerController = playerController;
            _screenController = screenController;
        }

        public void PlayButton()
        {
            _screenController.ChangeState(ScreenState.GameView);
        }

        public void SettingsButton()
        {
            
        }

        public void CloseButton()
        {
            Application.Quit();
        }
    }
}
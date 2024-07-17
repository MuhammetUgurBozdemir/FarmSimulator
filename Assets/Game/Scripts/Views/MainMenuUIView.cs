using Game.Scripts.Controllers;
using Game.Scripts.Enum;
using Game.Scripts.Player;
using Game.Scripts.Popup;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.Views
{
    public class MainMenuUIView : BaseScreen
    {
        [SerializeField] private GameObject buttonPanel;
        [SerializeField] private GameObject settingsPanel;

       [SerializeField] private Slider mouseSensitivity;

        private ScreenController _screenController;
        private PopupController _popupController;
        private PlayerController _playerController;
        private SettingsController _settingsController;

        [Inject]
        private void Construct(PopupController popupController,
            PlayerController playerController,
            ScreenController screenController,
            SettingsController settingsController)
        {
            _popupController = popupController;
            _playerController = playerController;
            _screenController = screenController;
            _settingsController = settingsController;
        }

        public void PlayButton()
        {
            _screenController.ChangeState(ScreenState.GameView);
        }

        public void SettingsButton()
        {
            buttonPanel.SetActive(false);
            settingsPanel.SetActive(true);
            mouseSensitivity.value = _settingsController.Sensitivity;
        }

        public void UpdateSettings()
        {
            _settingsController.Sensitivity = mouseSensitivity.value;
        }

        public void ReturnMainMenu()
        {
            buttonPanel.SetActive(true);
            settingsPanel.SetActive(false);
        }

        public void CloseButton()
        {
            
            Application.Quit();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Game.Scripts.Enum;
using Game.Scripts.Settings;
using Game.Scripts.Views;
using Zenject;

namespace Game.Scripts.Controllers
{
    public class ScreenController : BaseController
    {
        public GameView GameView => _gameView;
        public MainMenuUIView MainMenuUIView => _mainMenuUIView;
        public ScreenState CurrentState => _currentState;

        private GameView _gameView;
        private MainMenuUIView _mainMenuUIView;
        private readonly List<BaseScreen> _screens = new();
        private ScreenState _currentState;

        #region Injection

        private readonly PrefabSettings _prefabSettings;
        private readonly BaseScreen.Factory _screenFactory;
        private readonly DiContainer _diContainer;
        private SignalBus _signalBus;

        public ScreenController(PrefabSettings prefabSettings
            , BaseScreen.Factory screenFactory
            , DiContainer diContainer,
            SignalBus signalBus)
        {
            _prefabSettings = prefabSettings;
            _screenFactory = screenFactory;
            _diContainer = diContainer;
            _signalBus = signalBus;
        }

        #endregion

        public override void Initialize()
        {
            
        }

       

        public void ChangeState(ScreenState state)
        {
            CreateState(state);
        }

        private void CreateState(ScreenState state)
        {
            ClearScreens();
            _currentState = state;

            switch (_currentState)
            {
                case ScreenState.MainMenuView:
                    CreateMenuView();
                    break;
                case ScreenState.GameView:
                    CreateGameView();
                    break;
            }
        }


        private void CreateGameView()
        {
            _gameView = (GameView)_screenFactory.Create(_prefabSettings.GameView);
            _gameView.Initialize();
            _screens.Add(_gameView);
        }
        
        private void CreateMenuView()
        {
            _mainMenuUIView = (MainMenuUIView)_screenFactory.Create(_prefabSettings.MainMenuUIView);
            _mainMenuUIView.Initialize();
            _screens.Add(_mainMenuUIView);
        }



        private void ClearScreens()
        {
            foreach (var baseScreen in _screens.Where(baseScreen => baseScreen != null))
            {
                baseScreen.DestroyView(.5f);
            }
            
            _screens.Clear();
        }
        
        public override void Dispose()
        {
            _mainMenuUIView.Dispose();
        }
    }
}
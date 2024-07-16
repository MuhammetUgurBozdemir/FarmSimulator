using Game.Scripts.Inventory;
using Game.Scripts.Settings;
using Zenject;

namespace Game.Scripts.Controllers
{
    public class CurrencyController
    {
        public int coinAmount;
        private SignalBus _signalBus;
        private ScreenController _screenController;

        [Inject]
        private void Construct(SignalBus signalBus, ScreenController screenController)
        {
            _signalBus = signalBus;
            _screenController = screenController;
        }

        public void UpdateCoinAmount()
        {
            coinAmount += 900;
            _screenController.GameView.UpdateCurrency();
        }

        public bool ConsumeCoin(int amount)
        {
            if (amount > coinAmount) return false;

            coinAmount -= amount;
            _screenController.GameView.UpdateCurrency();

            return true;
        }
    }
}
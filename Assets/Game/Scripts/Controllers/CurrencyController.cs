using Game.Scripts.Inventory;
using Game.Scripts.Settings;
using Zenject;

namespace Game.Scripts.Controllers
{
    public class CurrencyController
    {
        public int coinAmount;
        private SignalBus _signalBus;
        
        [Inject]
        private void Construct(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        
    }
}

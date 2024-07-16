using Game.Scripts.Controllers;
using TMPro;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Views
{
    public class GameView : BaseScreen
    {
        [SerializeField] private TextMeshProUGUI coinText;
        [SerializeField] private TextMeshProUGUI loadAmountText;

        private CurrencyController _currencyController;

        [Inject]
        private void Construct(CurrencyController currencyController)
        {
            _currencyController = currencyController;
        }

        public void UpdateCurrency()
        {
            coinText.text = "Coin:" + _currencyController.coinAmount;
        }

        public void UpdateLoadAmount(int loadAmount)
        {
            loadAmountText.text = "Load Amount:" + loadAmount;
        }
    }
}
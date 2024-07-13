using UnityEngine;
using Zenject;

namespace Game.Scripts.Popup
{
    public class PopupView : BasePopupView
    {
        #region Injection

        protected PopupController _popupController;

        [Inject]
        private void Construct(PopupController popupController)
        {
            _popupController = popupController;
        }

        #endregion

        public override void ShowPopup()
        {
            
        }

        public override void ClosePopup()
        {
            base.ClosePopup();
            
            _popupController.ClosePopup(this);
            Destroy(gameObject);
        }
    }
}
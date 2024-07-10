using UnityEngine;

namespace Game.Scripts.Popup
{
    public class BasePopupView : MonoBehaviour, IPopupView
    {
        public void Init(PopupParameters parameters)
        {
        }

        public virtual void ShowPopup()
        {
        }

        public virtual void ClosePopup()
        {
        }

        public void DestroyPopup()
        {
        }
    }
}
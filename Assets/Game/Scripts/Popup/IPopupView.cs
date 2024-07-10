using UnityEngine;

namespace Game.Scripts.Popup
{
    public interface IPopupView
    {
        void Init(PopupParameters parameters);
        void ShowPopup();
        void ClosePopup();
        void DestroyPopup();
    }
}

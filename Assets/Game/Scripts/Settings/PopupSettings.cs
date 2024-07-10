using System.Collections.Generic;
using Game.Scripts.Popup;
using UnityEngine;

namespace Game.Scripts.Settings
{
   [CreateAssetMenu(fileName = nameof(PopupSettings), menuName = nameof(PopupSettings))]
   public class PopupSettings : ScriptableObject
   {
      public List<GameObject> PopupViews;

      public GameObject GetPopup(string popupName)
      {
         return PopupViews.Find(x => x.name == popupName);
      }
   }
}

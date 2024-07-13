using System;
using Game.Scripts.Popup;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Player
{
   public class DestinationController : MonoBehaviour
   {
      private Camera _mainCamera;
      private PopupController _popupController;

      [Inject]
      private void Construct([Inject(Id = "mainCam")] Camera mainCamera,PopupController popupController)
      {
         _mainCamera = mainCamera;
         _popupController = popupController;
      }

      private void OnCollisionEnter(Collision collision)
      {
         Debug.Log(collision.transform.tag);
      }

      private void OnTriggerEnter(Collider other)
      {
         if (other.CompareTag($"Market"))
         {
            _popupController.PopupRequest("MarketPopup",new PopupParameters());
         }
      }
   }
}

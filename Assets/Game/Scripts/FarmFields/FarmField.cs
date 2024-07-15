using System;
using System.Collections.Generic;
using DG.Tweening;
using Game.Scripts.Enum;
using Game.Scripts.Player;
using Game.Scripts.Popup;
using Game.Scripts.Settings;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.FarmFields
{
    public class FarmField : MonoBehaviour
    {
        [SerializeField] private FarmFieldsSettings farmFieldsSettings;
        [SerializeField] private List<MeshFilter> plantPoints;
        [SerializeField] private Slider slider;

        private int step;
        private PlayerController _playerController;

        private float _leftTime=5;

        [Inject]
        private void Construct(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void Init()
        {
           
        }

        public void Plant()
        {
            switch (step)
            {
                case 0:
                {
                    if (_playerController.GetItemData.OperatingType.Contains(OperationType.Digging))
                    {
                        foreach (var plantPoint in plantPoints)
                        {
                            plantPoint.mesh = farmFieldsSettings._farmFieldsData.Prefab[0];
                            
                            DOTween.To()
                        }
                    }

                    break;
                }
                case 1:
                {
                    if (_playerController.GetItemData.OperatingType.Contains(OperationType.Digging))
                    {
                        _leftTime =  _leftTime * 25 / 100;
                    }

                    break;
                }
                case 2:
                {
                    if (_playerController.GetItemData.OperatingType.Contains(OperationType.Harvesting))
                    {
                        foreach (var plantPoint in plantPoints)
                        {
                            plantPoint.mesh = null;
                            step = 0;
                        }
                    }

                    break;
                }
            }
        }
      
    }
}

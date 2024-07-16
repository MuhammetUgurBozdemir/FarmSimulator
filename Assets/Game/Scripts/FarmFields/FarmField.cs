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
        [SerializeField] private List<PlantPoints> plantPoints;
        [SerializeField] private Slider slider;

        private int step;
        public bool isProcessing;
        private PlayerController _playerController;

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
                        isProcessing = true;
                        foreach (var plantPoint in plantPoints)
                        {
                            plantPoint.meshFilter.transform.localScale=Vector3.zero;
                            plantPoint.meshFilter.mesh = farmFieldsSettings._farmFieldsData.Prefab[2];
                            
                            DOTween.To(() => slider.value,
                                x => slider.value = x, 1,
                                _playerController.GetItemData.ProcessTime).SetEase(Ease.OutQuad).OnComplete(() =>
                            {
                                plantPoint.ParticleSystem.SetActive(true);
                                slider.value = 0;
                            });

                            plantPoint.meshFilter.transform.DOScale(new Vector3(2, 2, 2),_playerController.GetItemData.ProcessTime);
                        }
                        step++;
                    }

                    break;
                }
                case 1:
                {
                    if (_playerController.GetItemData.OperatingType.Contains(OperationType.Harvesting))
                    {
                        foreach (var plantPoint in plantPoints)
                        {
                            plantPoint.meshFilter.mesh = null;
                            plantPoint.ParticleSystem.SetActive(true);
                            step = 0;
                        }
                    }

                    break;
                }
            }
        }
    }
}

[Serializable]
public class PlantPoints
{
    public MeshFilter meshFilter;
    [FormerlySerializedAs("ParticlrSystem")] public GameObject ParticleSystem;
}
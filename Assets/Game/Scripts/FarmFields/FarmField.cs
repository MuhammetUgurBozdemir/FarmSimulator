using System;
using System.Collections.Generic;
using Game.Scripts.Settings;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Scripts.FarmFields
{
    public class FarmField : MonoBehaviour
    {
        [FormerlySerializedAs("farmFieldsData")] [SerializeField] private FarmFieldsSettings farmFieldsSettings;
        [SerializeField] private List<MeshFilter> plantPoints;
        [SerializeField] private MeshRenderer meshRenderer;

        public void Init()
        {
           
        }

        public void Plant()
        {
            foreach (var plantPoint in plantPoints)
            {
                plantPoint.mesh = farmFieldsSettings._farmFieldsData.Prefab[0];
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag($"Spade"))
            {
                
            }
        }
    }
}

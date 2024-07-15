using System;
using System.Collections.Generic;
using Game.Scripts.Settings;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Scripts.FarmFields
{
    public class FarmField : MonoBehaviour
    {
        [SerializeField] private FarmFieldsSettings farmFieldsSettings;
        [SerializeField] private List<MeshFilter> plantPoints;
        
        
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
      
    }
}

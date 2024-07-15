using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Settings
{
    [CreateAssetMenu(fileName = nameof(FarmFieldsSettings), menuName = nameof(FarmFieldsSettings))]
    public class FarmFieldsSettings : ScriptableObject
    {
        public FarmFieldsData _farmFieldsData;
    }
}

[Serializable]
public class FarmFieldsData
{
    public string Name;
    public int Reward;
    public List<Mesh> Prefab;
}
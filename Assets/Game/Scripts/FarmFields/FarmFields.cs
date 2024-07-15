using System.Collections;
using System.Collections.Generic;
using Game.Scripts.FarmFields;
using UnityEngine;

public class FarmFields : MonoBehaviour
{
    [SerializeField] private List<FarmField> farmFields;

    public void Init()
    {
        foreach (var farmField in farmFields)
        {
            farmField.Init();
        }
    }
}

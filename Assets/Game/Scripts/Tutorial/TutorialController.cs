using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    [SerializeField] private GameObject ActiveParticle;
    [SerializeField] private GameObject DisableParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (ActiveParticle != null)
            ActiveParticle.gameObject.SetActive(false);
        
        if (DisableParticle != null)
            DisableParticle.gameObject.SetActive(true);
    }
}
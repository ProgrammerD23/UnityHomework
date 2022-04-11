using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverbZone : MonoBehaviour
{
    public AudioReverbZone component;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            component.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            component.enabled = false;
    }

}

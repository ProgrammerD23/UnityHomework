using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour
{
    public AudioSource component;
    public AudioClip stepClip;

    public void Step()
    {
        component.clip = stepClip;
        if (transform.position != Vector3.zero && !component.isPlaying)
            component.Play();
        else
            component.Stop();
    }
}

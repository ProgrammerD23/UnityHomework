using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSettings : MonoBehaviour
{
    
    public GameObject lanterns;

    public float speedRotate;

    
    void Update()
    {
        

        if (transform.rotation.x <= -5.268)
            lanterns.SetActive(false);
        else
            lanterns.SetActive(true);
        transform.Rotate(transform.right, speedRotate, Space.Self);
        
    }
}

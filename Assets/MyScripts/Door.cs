using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform rotatePoint;
    private bool isStop;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isStop)
        {
            rotatePoint.Rotate(Vector3.up, -90);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !isStop)
        {
            rotatePoint.Rotate(Vector3.up, 90);
        }
    }
}

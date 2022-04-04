using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform rotatePoint;
    private bool isStop;
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isStop)
        {
            //rotatePoint.Rotate(Vector3.up, -90);
            anim.SetBool("isOpen", true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !isStop)
        {
            //rotatePoint.Rotate(Vector3.up, 90);
            anim.SetBool("isOpen", false);
        }
    }
}

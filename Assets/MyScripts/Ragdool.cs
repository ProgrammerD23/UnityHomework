using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Ragdool : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Collider[] colliders;
    [SerializeField] private Rigidbody[] rigidbodys;
    [SerializeField] private ThirdPersonUserControl controler;
    [SerializeField] private float killForce;

    private void Start()
    {
        anim = GetComponent<Animator>();
        colliders = GetComponentsInChildren<Collider>();
        rigidbodys = GetComponentsInChildren<Rigidbody>();
        controler = GetComponent<ThirdPersonUserControl>();
    }
    void Update()
    {
        
        if (anim.GetBool("isActive"))
        {
            SetRagdool(true);
            anim.CompareTag("Active");
        }
    }

    private void SetRagdool(bool active)
    {
        for (int i = 0; i < rigidbodys.Length; i++)
        {
            rigidbodys[i].isKinematic = !active;
            if (active)
            {
                rigidbodys[i].AddForce(Vector3.forward * killForce, ForceMode.Impulse);
            }
        }
        for(int i = 0; i < colliders.Length; i++)
        {
            colliders[i].enabled = active;
        }
        controler.enabled = !active;
    }
}

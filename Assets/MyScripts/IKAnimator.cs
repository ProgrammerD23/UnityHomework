using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKAnimator : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Transform handObj;
    [SerializeField] private Transform lookObj;
    [SerializeField] private float rightHandWeight;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);

        anim.SetLookAtWeight(1);

        if (handObj)
        {
            anim.SetIKPosition(AvatarIKGoal.RightHand, handObj.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, handObj.rotation);
        }
        if (lookObj && Vector3.Distance(transform.position, lookObj.position) <= 2)
        {
            anim.SetLookAtPosition(lookObj.position);
        }
        
    }

}

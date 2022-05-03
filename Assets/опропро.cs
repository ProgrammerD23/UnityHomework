using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class опропро : StateMachineBehaviour
{
    public Animator anim;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        anim.SetBool("isActive", true);
    }
}

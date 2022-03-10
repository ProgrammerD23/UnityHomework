using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int helth;

    public void Hurt(int damage)
    {
        helth -= damage;

        if(helth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

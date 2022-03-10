using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    private Transform target;
    void FixedUpdate()
    {
        transform.position += transform.forward * speedBullet * Time.fixedDeltaTime;
    }

    public void Init(Transform _target, float lifeTime, float speed)
    {
        target = _target;
        speedBullet = speed;
        Destroy(gameObject, lifeTime);
    }
}

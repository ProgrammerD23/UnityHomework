using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    public float speedBullet2;
    private Transform target;
    private Rigidbody rbBullet;
    public float force;

    private void Awake()
    {
        rbBullet = GetComponent<Rigidbody>();
    }

    /* void FixedUpdate()
     {
         transform.position += transform.forward * speedBullet2 * Time.fixedDeltaTime;

     }*/

    public void Init(Transform _target, float lifeTime, float speed)
    {
        target = _target;
        speedBullet = speed;
        Destroy(gameObject, lifeTime);

        rbBullet.AddForce(transform.forward * force);
    }
}

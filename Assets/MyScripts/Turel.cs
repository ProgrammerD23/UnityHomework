using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject bullet;
    public float speed;
    public Transform bulletSpawn;

    private void Update()
    {
        if(Vector3.Distance(transform.position, playerPosition.position) < 6)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Fire();
            }
        }
    }
    void FixedUpdate()
    {
        Vector3 distation = playerPosition.position - transform.position;
        Vector3 rotateDis = Vector3.RotateTowards(transform.forward, distation, speed * Time.fixedDeltaTime, 0.0f);
        Quaternion rotate = Quaternion.LookRotation(rotateDis);
        transform.rotation = rotate;
    }

    private void Fire()
    {
        var bulletObj = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        var shield = bulletObj.GetComponent<Bullet>();
        shield.Init(playerPosition, 10, speed);
    }
}

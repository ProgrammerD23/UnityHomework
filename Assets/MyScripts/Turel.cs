using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject bullet;
    public float speed;
    public Transform bulletSpawn;
    public bool isFire;
    public float secondFire;

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        var vecPos = transform.position;
        vecPos.y += 0.5f;
        Debug.DrawRay(vecPos, transform.forward * 6, Color.blue);
        if(Physics.Raycast(ray, out RaycastHit hit, 6))
        {
            if (hit.collider.CompareTag("Player"))
            {
                if (isFire)
                {
                    Fire();
                }
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
        isFire = false;
        var bulletObj = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        var shield = bulletObj.GetComponent<Bullet>();
        shield.Init(playerPosition, 2, speed);

        Invoke(nameof(Fire), secondFire);
    }
}

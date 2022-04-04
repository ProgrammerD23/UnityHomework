using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JonhLemon : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;
    public int speedRotation;
    public Vector3 movement;
    public GameObject bomb;
    public Transform bombSpawn;
    public Animator anim;
    public float jumpForce;

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bomb, bombSpawn.position, bombSpawn.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        anim.SetBool("isWalking", movement != Vector3.zero);
    }

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3 (0, Input.GetAxis("Mouse X"), 0) * speedRotation);

        //var _speed = movement * speed * Time.deltaTime;
        // transform.Translate(_speed);
        movement = transform.TransformDirection(movement);
        rb.MovePosition(transform.position + movement.normalized * speed * Time.fixedDeltaTime);

    }
}

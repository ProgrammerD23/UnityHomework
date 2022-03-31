using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using System;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public int helth;
    private NavMeshAgent agent;
    //public Transform[] waypoints;
    //private int waypointIndex;
    public int speed;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
       // agent.SetDestination(waypoints[0].position);
    }

    private void Update()
    {
        //StartCoroutine(Des());
        StartCoroutine(Destination());
        
    }

    public void Hurt(int damage)
    {
        helth -= damage;

        if(helth <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Destination()
    {
        Ray ray = new Ray(transform.position, player.position - transform.position);
        var vecPos = transform.position;
        vecPos.y += 0.5f;
        Debug.DrawRay(vecPos, player.position - transform.position, Color.red);
        if (Physics.Raycast(ray, out RaycastHit hit, 100))
        {
            if (hit.collider.CompareTag("Player"))
            {
                //StopCoroutine(Des());
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else
            {
                yield return new WaitForSeconds(10f);
            }
        }
        yield return null;
    }

   /* IEnumerator Des()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            waypointIndex = (waypointIndex + 1) % waypoints.Length;
            agent.SetDestination(waypoints[waypointIndex].position);
        }
        
        yield return null;
    }*/

}

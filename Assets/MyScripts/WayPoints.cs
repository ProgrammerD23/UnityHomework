using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{
    public NavMeshAgent meshAgent;
    public Transform[] waypoints;
    private int waypointIndex;

    void Start()
    {
        meshAgent.SetDestination(waypoints[0].position);
    }

    void Update()
    {
        if(meshAgent.remainingDistance <= meshAgent.stoppingDistance)
        {
            waypointIndex = (waypointIndex + 1) % waypoints.Length;
            meshAgent.SetDestination(waypoints[waypointIndex].position);
        }
    }
}

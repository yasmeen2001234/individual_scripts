using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent_AI : MonoBehaviour
{

    public List<Transform> wayPoint; 

    NavMeshAgent navMeshAgent;

    public int currentWaypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Walking();
    }

    private void Walking()
    {

      

        if (wayPoint.Count == 0)
        {
     
            return;
        }

     
        float distanceToWaypoint = Vector3.Distance(wayPoint[currentWaypointIndex].position, transform.position);

        // Check if the agent is close enough to the current waypoint
        if (distanceToWaypoint <= 2)
        {
         
            currentWaypointIndex = (currentWaypointIndex + 1) % wayPoint.Count;
        }

        // Set the destination to the current waypoint
        navMeshAgent.SetDestination(wayPoint[currentWaypointIndex].position);
    }

}

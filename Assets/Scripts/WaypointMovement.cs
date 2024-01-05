using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (currentWaypointIndex >= (waypoints.Length))
            currentWaypointIndex = 0;

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);

        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < 0.1f)
            currentWaypointIndex++;
        
    }
}

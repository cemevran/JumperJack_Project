using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currrentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[currrentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currrentWaypointIndex++;
            if (currrentWaypointIndex >= waypoints.Length)
            {
                currrentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currrentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
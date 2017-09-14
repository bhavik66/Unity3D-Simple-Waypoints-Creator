using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    int activeWaypointIndex = 1;

    // Use this for initialization
    void Start()
    {
        transform.position = WaypointsManager.instance.waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, WaypointsManager.instance.waypoints[activeWaypointIndex].position, .05f);
        if (transform.position == WaypointsManager.instance.waypoints[activeWaypointIndex].position)
            if (activeWaypointIndex < WaypointsManager.instance.waypoints.Count - 1)
                activeWaypointIndex++;
            else
                activeWaypointIndex = 0;
    }
}

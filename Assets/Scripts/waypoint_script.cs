using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint_script : MonoBehaviour {

    // A transform array of the waypoints
    public static Transform[] points;

    // Setting up the array for all of the children of waypoints
    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}

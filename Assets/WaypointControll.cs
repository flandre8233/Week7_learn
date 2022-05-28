using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaypointControll : SingletonMonoBehavior<WaypointControll>
{
    [SerializeField] Image[] waypoints;

    public void ActiveWaypoints()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("PlayerView");
        for (int i = 0; i < objs.Length; i++)
        {
            objs[i].GetComponent<Waypoint>().img = waypoints[i];
        }
        objs[0].GetComponent<Waypoint>().target = objs[1].transform;
        objs[1].GetComponent<Waypoint>().target = objs[0].transform;
    }
}

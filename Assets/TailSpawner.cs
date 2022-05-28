using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailSpawner : MonoBehaviour
{
    [SerializeField] static GameObject SpawnPrefab = Resources.Load<GameObject>("Tail");

    public static GameObject Create(Transform SpawnPoint, SpherePlanet Planet)
    {
        GameObject SpawnObject = Instantiate(SpawnPrefab, SpawnPoint);
        SpawnObject.transform.position -= SpawnPoint.forward;
        SpawnObject.transform.parent = null;
        SpawnObject.name = SpawnPrefab.name;
        SpawnObject.GetComponent<PlanetStick>().planet = Planet;

        return SpawnObject;
    }
}

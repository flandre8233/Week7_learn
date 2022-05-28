using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBotSpawner : SingletonMonoBehavior<AutoBotSpawner>
{
    [SerializeField] SpherePlanet planet;
    public GameObject Create()
    {
        Vector3 SpawnPoint = PlayerOtherSide.instance.GetPlayerOtherSide();
        SpawnPoint = planet.PolarToV3(SpawnPoint.x, SpawnPoint.y, SpawnPoint.z);
        
        GameObject SpawnPrefab = Resources.Load<GameObject>("AutoBot");
        GameObject SpawnObject = Instantiate(SpawnPrefab, planet.transform);
        SpawnObject.transform.position = SpawnPoint;
        SpawnObject.transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
        SpawnObject.name = SpawnPrefab.name;
        SpawnObject.GetComponent<PlanetStick>().planet = planet;
        SpawnObject.GetComponent<PlanetGrav>().planet = planet;
        return SpawnObject;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : SingletonMonoBehavior<AsteroidSpawner>
{
    public List<AsteroidPushMovement> Asteroids = new List<AsteroidPushMovement>();

    public GameObject Create(Transform SpawnPoint)
    {
        GameObject SpawnPrefab = Resources.Load<GameObject>("Asteroid");
        GameObject SpawnObject = Instantiate(SpawnPrefab, SpawnPoint);
        SpawnObject.name = SpawnPrefab.name;
        SpawnObject.transform.eulerAngles = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        SpawnObject.transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
        AsteroidPushMovement asteroid = SpawnObject.GetComponent<AsteroidPushMovement>();
        asteroid.BeltTransform = SpawnPoint;
        Asteroids.Add(asteroid);
        return SpawnObject;
    }

    private void Start()
    {
        SpawnBelt();
    }

    public void SpawnBelt()
    {
        for (int i = 0; i < 200; i++)
        {
            Create(transform);
        }
    }

    public void DestroyAllAsteroid()
    {
        foreach (var item in Asteroids)
        {
            item.gameObject.AddComponent<AsteroidDestroyer>();
        }
    }
}

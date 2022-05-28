using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSurfaceLZ : SingletonMonoBehavior<PlanetSurfaceLZ>
{
    [SerializeField] SpherePlanet Planet;
    public Vector3 GetAcceptableLZ()
    {
        return Planet.RandomSurface();
    }
}

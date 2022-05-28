using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOtherSide : SingletonMonoBehavior<PlayerOtherSide>
{
    [SerializeField] SpherePlanet Planet;
    [SerializeField] Transform PlayerTrans;
    private void Update()
    {
        GetPlayerOtherSide();
    }

    public Vector3 GetPlayerOtherSide()
    {
        Vector3 PlayerPolar = GetPlayerPolar();
        PlayerPolar.z -= 180;
        return PlayerPolar;
    }

    public Vector3 GetPlayerPolar()
    {
        return Planet.V3ToPolar(PlayerTrans.position);
    }

    void OnDrawGizmosSelected()
    {
        Vector3 OtherSide = GetPlayerOtherSide();
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(Planet.PolarToV3(OtherSide.x, OtherSide.y, OtherSide.z), 1);
    }
}

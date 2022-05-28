using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadControll : MonoBehaviour
{
    [SerializeField] Renderer View;
    public void Dead()
    {
        ResourcesSpawner.Spawn("Dead");

        PlayerController WhoDead = GetComponent<PlayerController>();
        GetComponentInChildren<Camera>().gameObject.AddComponent<PlayerCameraLeave>();
        View.gameObject.AddComponent<Dissolve>();
        Destroy(WhoDead);
        Destroy(gameObject, 5f);
        SendDeadConfirmToListen();

    }

    public void SendDeadConfirmToListen()
    {
        GameoverListener.instance.SomeoneDead = true;
        GameoverListener.instance.IsLeftSideWin = (!GetComponent<PlayerController>().PlayerLeftSide);
        GameoverListener.instance.CheckGameover();
    }
}

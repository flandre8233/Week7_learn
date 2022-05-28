using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class GameStatus : Status
{
    public override void Start()
    {
        UICanvasControll.CloseAllUIExpectIndex(1);
        AsteroidSpawner.instance.DestroyAllAsteroid();
        WaypointControll.instance.ActiveWaypoints();
        GameResultUIView.instance.HideResultUI();
        PlayerInputManagerListener.instance.StartRun();
    }

    public override void Update()
    {

    }

    public override void ExitStatus()
    {
    }
}
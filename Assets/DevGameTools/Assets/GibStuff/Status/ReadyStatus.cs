using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
public class ReadyStatus : Status
{
    public override void Start()
    {
        Debug.Log("ReadyStatus");
        UICanvasControll.CloseAllUIExpectIndex(0);
    }

    public override void Update()
    {
        if (PlayerInputManagerListener.instance.IsPlayerFull())
        {
            ReadyCanvasAniControl.instance.SetExit();
            DelayDoEventHandler.Create(StartGameDelay, 3f);
            StatusControll.ClearStatus();

        }
    }

    public override void ExitStatus()
    {

    }

    void StartGameDelay()
    {
        StatusControll.ToNewStatus(new GameStatus());
    }
}
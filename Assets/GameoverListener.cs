using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverListener : SingletonMonoBehavior<GameoverListener>
{
    public bool SomeoneDead = false;
    public bool IsLeftSideWin = false;
    public void CheckGameover()
    {
        if (IsGameover())
        {
            GameResultUIView.instance.ShowResult();
            Invoke("OnGameover", 4);
        }
    }
    bool IsGameover()
    {
        return SomeoneDead;
    }

    void OnGameover()
    {
        StatusControll.ToNewStatus(new ResultStatus());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResultStatus : Status
{
    public override void Start()
    {
        UICanvasControll.CloseAllUIExpectIndex(2);

        //PlayerInputManagerListener.instance.DestroyAllInputsObj();
        //GameObject LoseCamera = GameObject.FindGameObjectWithTag("LoseCamera");
        //GameObject.Destroy(LoseCamera);
        CameraControl.instance.BackToStartStatus();
        //AsteroidSpawner.instance.SpawnBelt();

        StatusControll.ToNewStatus(new AdsStatus());

        if (Random.Range(0, 100) <= 20)
        {
            // DelayDoEventHandler.Create(LoadScneDelay, 0.75f);
        }
        else
        {
        }
    }

    public override void Update()
    {

    }

    public override void ExitStatus()
    {

    }

    void LoadScneDelay()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}

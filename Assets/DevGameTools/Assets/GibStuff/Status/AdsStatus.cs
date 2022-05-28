using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdsStatus : Status
{
    public override void Start()
    {
        Debug.Log("Ads status");
        DelayDoEventHandler.Create(LoadScneDelay, 10f);
    }

    public override void Update()
    {
        Debug.Log("status Update");
    }

    public override void ExitStatus()
    {

    }

    void LoadScneDelay()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}

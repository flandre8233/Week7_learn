using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : SingletonMonoBehavior<CameraControl>
{
    [SerializeField] Animator CameraAni;
    public void BackToStartStatus()
    {
        //CameraAni.enabled = false;
        GetComponent<Animator>().SetTrigger("reverse");
    }
}

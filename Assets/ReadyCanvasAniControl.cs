using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyCanvasAniControl : SingletonMonoBehavior<ReadyCanvasAniControl>
{
    [SerializeField] Animator animator;
    [SerializeField] Animator CameraAni;

    public void SetExit()
    {
        animator.SetTrigger("Exit");
        CameraAni.enabled = true;
    }
}

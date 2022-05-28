using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class InputListener<T> : MonoBehaviour where T : struct
{
    protected PlayerControls controls;
    protected InputAction TargetInputAction;
    public T DataVal;
    private void Awake()
    {
        controls = new PlayerControls();
        InitAction();
        TargetInputAction.performed += ctx => DataVal = ctx.ReadValue<T>();
        TargetInputAction.canceled += ctx => DataVal = default(T);
    }

    protected abstract void InitAction();

    private void OnEnable()
    {
        TargetInputAction.Enable();
    }

    private void OnDisable()
    {
        TargetInputAction.Disable();
    }

}

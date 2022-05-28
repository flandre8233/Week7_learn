using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputMove : InputListener<float>
{
    protected override void InitAction()
    {
        TargetInputAction = controls.GamePlay.Forward;
    }
}

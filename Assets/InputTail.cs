using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTail : InputListener<float>
{
    protected override void InitAction()
    {
        TargetInputAction = controls.GamePlay.Tail;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRotate : InputListener<Vector2>
{
    protected override void InitAction()
    {
        TargetInputAction = controls.GamePlay.Rotate;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public bool RunLock = true;
    public bool PlayerLeftSide;
    [SerializeField] float InputMove;
    [SerializeField] float InputBreak;
    [SerializeField] Vector2 InputRotate;

    [SerializeField] SimpleForward Forward;
    [SerializeField] SimpleRotate Rotate;

    [SerializeField] MoveDistanceListener moveDistance;

    [SerializeField] Nitrogen nitrogen;

    // Update is called once per frame
    void Update()
    {
        if (RunLock)
        {
            return;
        }
        float SpeedUpRatio = nitrogen.Loss(InputMove);
        float Break = nitrogen.Loss(InputBreak);
        print(InputBreak);
        Forward.Move(SpeedUpRatio + 0.5f - (Break * 0.4f));
        Rotate.Rotate(InputRotate.x * ((SpeedUpRatio * .3f) + 0.7f));

        if (moveDistance.GetIsDistanceMovedCurFrame())
        {
            OnMoveDistance();
        }
    }

    void OnMoveDistance()
    {
        TailSpawner.Create(transform, GetComponent<PlanetStick>().planet);
    }

    public void OnForward(InputValue value)
    {
        float DataVal = value.Get<float>();
        InputMove = DataVal;
    }
    public void OnRotate(InputValue value)
    {
        Vector2 DataVal = value.Get<Vector2>();
        InputRotate = DataVal;
    }
    public void OnTail()
    {
        print("OnTail");
    }
    public void OnBreak(InputValue value)
    {
        float DataVal = value.Get<float>();
        InputBreak = DataVal;
    }
}

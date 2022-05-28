using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBotController : MonoBehaviour
{
    [SerializeField] SimpleForward Forward;
    [SerializeField] SimpleRotate Rotate;

    [SerializeField] MoveDistanceListener moveDistance;

    // Update is called once per frame
    void Update()
    {
        Forward.Move(1);
        //Rotate.Rotate(InputRotate.DataVal.x * InputMove.DataVal);

        if (moveDistance.GetIsDistanceMovedCurFrame())
        {
            OnMoveDistance();
        }
    }

    void OnMoveDistance()
    {
        TailSpawner.Create(transform, GetComponent<PlanetStick>().planet);
    }
}

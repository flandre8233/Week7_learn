using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistanceListener : MonoBehaviour
{
    [SerializeField] float Disantce;
    Vector3 PrevPos;

    bool IsDistanceMovedCurFrame = false;

    // Update is called once per frame
    void Update()
    {
        IsDistanceMovedCurFrame = false;
        if (Vector3.Distance(PrevPos, transform.position) > Disantce)
        {
            PrevPos = transform.position;
            IsDistanceMovedCurFrame = true;
        }
    }

    public bool GetIsDistanceMovedCurFrame()
    {
        return IsDistanceMovedCurFrame;
    }
}

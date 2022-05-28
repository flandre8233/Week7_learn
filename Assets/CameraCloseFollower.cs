using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseFollower : MonoBehaviour
{
    public Transform target;
    public float distance = 3.0f;
    public float height = 3.0f;
    public float damping = 5.0f;
    public bool smoothRotation = true;
    public bool followBehind = true;
    public float rotationDamping = 10.0f;

    Vector3 wantedPosition;
    Vector3 TargetPosition;

    void LateUpdate()
    {
        if (followBehind)
        {
            TargetPosition = new Vector3(0, height, -distance);
        }
        else
        {
            TargetPosition = new Vector3(0, height, distance);
        }
        wantedPosition = target.TransformPoint(TargetPosition) + (target.up * 4);
        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);

        Vector3 TargetLook = target.position + (target.up * 1);
        if (smoothRotation)
        {
            //Quaternion wantedRotation = target.rotation;
            Quaternion wantedRotation = Quaternion.LookRotation(TargetLook - transform.position, target.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
        }
        else
        {
            transform.LookAt(TargetLook, target.up);
        }

    }

}

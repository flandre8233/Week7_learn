using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidPushMovement : MonoBehaviour
{
    public Transform BeltTransform;
    Vector3 TargetPoint;

    private void Start()
    {
        Vector3 RandomCircle = Random.insideUnitCircle;
        RandomCircle = new Vector3(RandomCircle.x, 0, RandomCircle.y);
        TargetPoint = RandomCircle * 100;
        // /transform.position = TargetPoint;
    }
    private void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, TargetPoint, Time.deltaTime);
    }

}

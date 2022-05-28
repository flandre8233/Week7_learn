using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleForward : MonoBehaviour
{
    [SerializeField] Rigidbody RB;
    [SerializeField] float Speed;
    public void Move(float move)
    {
        RB.MovePosition(transform.position + move * transform.forward * Time.deltaTime * Speed );
    }
}

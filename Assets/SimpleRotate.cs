using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    [SerializeField] float Speed;
    public void Rotate(float Rotate)
    {
        transform.Rotate(new Vector3(0, Rotate * Time.deltaTime * Speed ,0));  ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Speed * Time.deltaTime, 0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestoryer : MonoBehaviour
{
    [SerializeField] float Timer;
    void Start()
    {
        Destroy(gameObject, Timer);
        Destroy(this);
    }
}

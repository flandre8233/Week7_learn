using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    [SerializeField] float Progress = 1;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        Progress = 1;
    }

    void Update()
    {
        Progress = Mathf.Lerp(Progress, 0, Time.deltaTime * 1.5f);
        rend.material.SetFloat("_Progress", Progress);
    }
}

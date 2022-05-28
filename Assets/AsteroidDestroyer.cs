using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(), Time.deltaTime * 2);
    }

}

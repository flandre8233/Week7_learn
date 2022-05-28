using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraLeave : MonoBehaviour
{
    Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = transform.parent;
        transform.parent = null;
        Destroy(this, 3f);
        gameObject.tag = "LoseCamera";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = Target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = Quaternion.Slerp( transform.rotation,rotation,Time.deltaTime * 3);

        transform.position -= transform.forward * Time.deltaTime;
    }
}

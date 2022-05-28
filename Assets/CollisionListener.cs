using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionListener : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tail"))
        {
            print("Hit");
            Destroy(this);
            gameObject.GetComponent<DeadControll>().Dead();
        }
    }
}

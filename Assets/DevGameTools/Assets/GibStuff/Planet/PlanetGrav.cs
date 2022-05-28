using UnityEngine;
using System.Collections;

public class PlanetGrav : MonoBehaviour
{
    public SpherePlanet planet;
    static float StrengthOfAttraction = 9.8f;
    [SerializeField] Rigidbody ObjectRB;

    private void Start()
    {
        ObjectRB = GetComponent<Rigidbody>();
        ObjectRB.useGravity = false;
    }

    void FixedUpdate()
    {
        float magsqr;
        Vector3 offset;
        offset = planet.transform.position - transform.position;
        magsqr = offset.sqrMagnitude;

        if (magsqr > 0.0001f)
        {
            ObjectRB.AddForce((StrengthOfAttraction * 100 * offset.normalized / magsqr) * ObjectRB.mass);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceJunk : MonoBehaviour
{
    public Transform planet; 
    public float rotationSpeed = 50f; 
    public float orbitSpeed = 10f; 
    public float orbitRadius = 10f; 

    private Vector3 orbitAxis; 

    void Start()
    {
        orbitAxis = Random.onUnitSphere;
        transform.position = planet.position + orbitAxis * orbitRadius;
    }

    void Update()
    {  
        transform.RotateAround(planet.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

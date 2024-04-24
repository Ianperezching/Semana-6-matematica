using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidad de rotación

    void Update()
    {
        // Rotar la esfera sobre su propio eje
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
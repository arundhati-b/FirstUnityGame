using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Sphere;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - Sphere.transform.position;
    }
    
    void LateUpdate ()
    {
        transform.position = Sphere.transform.position + offset;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveBehaviour : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Vector2 center;
    [SerializeField]
    private float radius;

    private void FixedUpdate()
    {
        var x = transform.position.x;
        var a = center.x;
        var b = center.y;
        
        if (Mathf.Abs(radius) > Mathf.Abs(x - a))
        {
            // (x - a)^2 + (z - b)^2 = r^2 => z = b + sqrt(r^2 - (x - a)^2)
            var newZ = b + Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x - a, 2));
            var newPosition = new Vector3(x, transform.position.y, newZ);
            
            rb.MovePosition(newPosition);
        }
    }
}

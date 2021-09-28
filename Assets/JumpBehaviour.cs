using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    private const KeyCode JumpButton = KeyCode.Space;

    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float strength;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(JumpButton))
        {
            rb.AddForce(new Vector3(strength, strength));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    Rigidbody rb;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity =  Vector2.ClampMagnitude(rb.velocity, speed);
    }
}

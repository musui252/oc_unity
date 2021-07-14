using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBall : MonoBehaviour
{

    public float speed = 10.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            rb.AddForce(transform.forward * speed);
        }
       
    }
}

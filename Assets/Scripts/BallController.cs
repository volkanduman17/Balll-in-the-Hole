using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    bool IsThrowed;
     void Start()
    {
        rb =GetComponent<Rigidbody>();
    }

    public void Shoot(Vector3 _force)
    {
        rb.velocity = (_force);
        IsThrowed = true;
    }

    void FixedUpdate()
    {
        if (IsThrowed)
        {
            if (rb.velocity.magnitude <= 0.1f)
            {
                rb.isKinematic = true;
                //rb.velocity = new Vector3(0, 0, 0);
            }
            if (rb.velocity.magnitude <= 3f)
            {
                rb.velocity = 0.99f * rb.velocity;
            }
        }       
    }
}

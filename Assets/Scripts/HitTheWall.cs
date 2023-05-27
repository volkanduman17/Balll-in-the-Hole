using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTheWall : MonoBehaviour
{
    Rigidbody rb;
    private Vector3 lastvelocity;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "wall")
        {
            //  UI_Manager.coinAmount += 1;
            UICurrencyManager.Instance.GoldCollected();
            var speed = lastvelocity.magnitude;
            var direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

    }
    private void Update()
    {
        lastvelocity = rb.velocity;
    }
}

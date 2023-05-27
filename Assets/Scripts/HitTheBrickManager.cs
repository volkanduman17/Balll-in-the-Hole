using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTheBrickManager : MonoBehaviour
{
    public float PurpleBrickBuffSpeed = 10f ;
    public float BlackBrickNerfSpeed = -10f ;
    Rigidbody rb;
    private Vector3 lastvelocity;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "brick")
        {
            var speed = lastvelocity.magnitude;
            var direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

        if (collision.collider.tag == "purpleBrick")
        {
            var speed = lastvelocity.magnitude;
            var direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed+PurpleBrickBuffSpeed, 0f);
        }

        if (collision.collider.tag == "blackBrick")
        {
            var speed = lastvelocity.magnitude;
            var direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed + BlackBrickNerfSpeed, 0f);
        }

        if (collision.collider.tag == "tntBrick")
        {
            var speed = lastvelocity.magnitude;
            var direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed + BlackBrickNerfSpeed, 0f);
            Destroy(GameObject.FindWithTag("tntBrick"));
        }

        if (collision.collider.tag == "yellowBrick")
        {
            var speed = lastvelocity.magnitude;
            var direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

        if (collision.collider.tag == "yellowBrick_2")
        {
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

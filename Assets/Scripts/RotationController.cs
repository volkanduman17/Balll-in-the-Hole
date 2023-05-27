using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotationController : MonoBehaviour
{
    public Vector3 rotationValue;
    void Update()
    {
        Turn();
    }
    public void Turn()
    {
        transform.Rotate(rotationValue * 50 * Time.deltaTime, Space.Self);
    }
}


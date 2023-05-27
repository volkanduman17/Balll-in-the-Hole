using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragController : MonoBehaviour
{
    public float power = 100f;
    public float maxDrag = 5f;
    public LineRenderer lineRenderer;
    public Ray startRay;
    Vector3 rayVector;
    Vector3 dragStartPos;
    Touch touch;
    public float forceSpeed;
    public float maxLength = 50f;
    [HideInInspector]
    public bool IsBall = false;
    public RaycastHit hit;
    Vector3 dragLastPos;

    private BallController _currentBall;
    public LayerMask mask;

    public void DragStart(Touch touch)
    {

            startRay = Camera.main.ScreenPointToRay(touch.position);
            
            if(Physics.Raycast(startRay, out hit, 100, mask))
            {
                 dragStartPos = hit.transform.position;
                 dragStartPos.y = 1;
                 lineRenderer.positionCount = 1;
                 lineRenderer.SetPosition(0, dragStartPos);
                 if (hit.collider.gameObject.CompareTag("ballTouch"))
                 {
                     _currentBall = hit.collider.gameObject.GetComponentInParent<BallController>();
                     hit.collider.gameObject.SetActive(false);
                IsBall = true;
                 }
            }               
    }

    public void Dragging(Touch touch)
    {
        startRay = (Camera.main.ScreenPointToRay(touch.position));
        Physics.Raycast(startRay, out hit);
        dragLastPos = hit.point;

        rayVector = dragStartPos * 2 + hit.point * -1;
        rayVector.y = 1;

        //rayVector = Vector3.ClampMagnitude(rayVector, 1f);


       // Mathf.Clamp(maxLength, 0, 4);

        dragLastPos.y = 1;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(1, rayVector);


    }

    public void DragRelease(Touch touch)
    {
        IsBall = false;
        lineRenderer.positionCount = 0;
        Vector3 force = dragStartPos - dragLastPos;
        //Vector3 clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
        //rb.AddForce(clampedForce, ForceMode.Impulse);
        Vector3 speed = force * forceSpeed;
        _currentBall.Shoot(speed);

        IsBall = false;
        GetComponent<TouchBallControl>().isThrow = true;
    }
}

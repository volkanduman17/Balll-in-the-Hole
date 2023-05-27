using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBallControl : MonoBehaviour
{

    Touch touch;
    DragController _drag;
   // bool IsBall;
   public bool isThrow = false;
    void Start()
    {
        _drag = GetComponent<DragController>();
    }

    void Update()
    {
        TouchControl();
    }

    public void TouchControl()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if (touch.phase==TouchPhase.Began)
            {
                    _drag.DragStart(touch);
            }

            if (touch.phase==TouchPhase.Moved)
            {
                if (_drag.IsBall)
                    _drag.Dragging(touch);
            }

            if (touch.phase==TouchPhase.Ended)
            {
                if (_drag.IsBall)
                    _drag.DragRelease(touch);                    
            }
        }
    }    
}


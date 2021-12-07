using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    #region FIELDS
    Vector3 mouseDownPosition;
    Vector3 mouseUpPosition;

    bool clicked = false;

    bool shouldRotate = false;

    float rotationAngle = 90;
    #endregion

    #region MONOBEHAVIOUR METHODS 
    void Start()
    {
    }
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            shouldRotate = true;
        }
        RotateDown();

        Debug.Log(transform.eulerAngles.x);

    }
    #endregion
    void RotateOnClick()
    {

        if (Input.GetMouseButton(0))
        {
            //transform.Rotate(1.0f, 0.0f, 0.0f, Space.World);
            Debug.Log(transform.eulerAngles.x);
        }
    }

    void RotateDown()
    {
        if (shouldRotate)
        {       
            if (transform.eulerAngles.x < 180)
            {
                transform.Rotate(90f, 0.0f, 0.0f, Space.World);
            }
            else
            {
                shouldRotate = false;
                rotationAngle += 90;
            }
        }

    }

    void MouseDirection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDownPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseUpPosition = Input.mousePosition;
            clicked = true;
        }

        if (clicked && (mouseDownPosition.y < mouseUpPosition.y))
        {
            Debug.Log("Moved mouse up");
            clicked = false;
        }
        else if (clicked && (mouseDownPosition.y > mouseUpPosition.y))
        {
            Debug.Log("Moved mouse down");
            clicked = false;
        }
    }


        
    #region METHODS 
    #endregion
}

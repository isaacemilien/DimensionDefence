using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    #region FIELDS
    Vector3 mouseDownPosition;
    Vector3 mouseUpPosition;

    bool clicked = false;

    float time;

    #endregion

    #region MONOBEHAVIOUR METHODS 
    void Start()
    {
    }
	
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            clicked = true;
        }

        if (clicked)
        {
            time += Time.deltaTime;
            if (transform.rotation.x > 10)
            {
                time = 0;
                clicked = false;
            }
            else
            {
                transform.Rotate(.3f, 0.0f, 0.0f, Space.World);
            }
        }
    }
    #endregion
    void RotateOnClick()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(1.0f, 0.0f, 0.0f, Space.World);
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

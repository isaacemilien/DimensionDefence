using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    #region ATTRIBUTES  
    float timeCount;
    [SerializeField] float slowTime = 0.02f;

    float currentAngle = 0;


    #endregion

    #region MONOBEHAVIOUR METHODS

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && transform.eulerAngles.x == currentAngle % 360)
        {
            currentAngle += 90f;
            timeCount = 0;
        }
        if (transform.eulerAngles.x != currentAngle % 360)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(currentAngle, 0, 0), timeCount);
            timeCount += Time.deltaTime * slowTime;
            Debug.Log("sadfasdfasdfafaddfasdfsadfafas");

            Debug.Log(transform.eulerAngles.x);
            Debug.Log(currentAngle);
        }
    }
    #endregion

    #region METHODS

    #endregion
}

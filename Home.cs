using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    // IF COLLIDE WITH OBJECT WITH ENEMY TAG DO SOMETHING
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("Breached");
        }
    }
}

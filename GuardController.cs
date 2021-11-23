using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    #region ATTRIBUTES
    float time;
    [SerializeField] float attackSpeed = 2;
    #endregion

    #region MONOBEHAVIOUR METHODS
    void Start()
    {
    }

    void Update()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy")
        {
            var damageable = other.GetComponent<IDamageable>();
            damageable.Damage(Attack());
        }
    }
    #endregion
    #region METHODS
    float Attack()
    {
        time += Time.deltaTime;
        if (time > attackSpeed)
        {
            Debug.Log("Attacking!");
            time = 0;
            return 10f;
        }
        else
        {
            return 0f;
        }
    }
    #endregion
}

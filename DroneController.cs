using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class DroneController : MonoBehaviour, IMoveable, IDamageable
{
    [SerializeField] Transform goal;
    public float droneHealth = 100f;

    void Start()
    {
        Move();
    }
    public void Move()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
    public void Damage(float damageTaken)
    {
        droneHealth -= damageTaken;
    }
}
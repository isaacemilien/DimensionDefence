using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class DroneController : MonoBehaviour, IMoveable
{
    [SerializeField] Transform goal;

    void Start()
    {
        Move();
    }
    public void Move()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
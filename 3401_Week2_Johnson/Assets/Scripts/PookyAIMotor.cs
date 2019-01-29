using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PookyAIMotor : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;

    // Update is called once per frame
    void Update()
    {
        Destination();
    }
    void Destination()
    {
        agent.SetDestination(destination.position);
    }
}

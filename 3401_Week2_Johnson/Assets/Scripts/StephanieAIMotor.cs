using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StephanieAIMotor : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;
    public float speed = 7.5f;
    // Update is called once per frame
    private void Start()
    {
        speed = agent.speed;
    }
    void Update()
    {
        Destination();
        SlowDown();
    }
    void Destination()
    {
        agent.SetDestination(destination.position);
    }
    void SlowDown()
    {
        agent.speed = speed;
        if (speed > 0)
        {
            speed -= Time.deltaTime;
        }
    }
}

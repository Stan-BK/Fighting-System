using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    protected NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
         agent = GetComponent<NavMeshAgent>();
    }

    protected virtual void FixedUpdate()
    {
        agent.destination = goal.position;
    }
}

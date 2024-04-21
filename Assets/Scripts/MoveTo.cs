using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    public OffMeshLink OffMeshLink;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
         agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        agent.destination = goal.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadSceneAsync("Another", LoadSceneMode.Additive).completed += (e) =>
        {
            goal = GameObject.FindGameObjectsWithTag("Point")[0].transform;
            OffMeshLink.endTransform = goal;
        };
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMoveZoombie : MoveTo
{
    public GameObject[] list = new GameObject[3];
    int i = 0;
    // Start is called before the first frame update
    void Awake()
    {
        goal = list[i].transform;
    }

    // Update is called once per frame
    protected override void FixedUpdate()
    {
        if (agent.remainingDistance < 0.01) {
            goal = list[++i > 2 ? (i = 0) : i].transform;
        }
        base.FixedUpdate();

    }
}

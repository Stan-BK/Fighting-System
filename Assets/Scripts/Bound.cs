using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    public MeshCollider collider;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDrawGizmos(){
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(collider.bounds.max, .1f);
        Gizmos.color = Color.yellow;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(collider.bounds.min, .1f);
    }
}

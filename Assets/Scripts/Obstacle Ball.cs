using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBall : MonoBehaviour
{
    float t = 0;
    CharacterController controller;
    float speed = .1f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        if (Time.time - t > .8)
        {
            t = Time.time;
            speed = -speed;
        }
        controller.Move(new Vector3(speed, 0, 0));
    }
}

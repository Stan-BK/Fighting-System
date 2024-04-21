using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossSceneZombie : MoveTo
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cross Scene Point"))
            SceneManager.LoadSceneAsync("Another", LoadSceneMode.Additive).completed += (e) =>
            {
                goal = GameObject.FindGameObjectWithTag("Cross Scene Land Point").transform;
            };
    }
}

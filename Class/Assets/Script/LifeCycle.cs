using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    int health = 0;

    private void Awake() // <- 1¹øÂ°
    {
        Debug.Log("Tiger Awake");
    }

    void Start()
    {
        Debug.Log("Tiger Start");
    }

    private void OnEnable()
    {
        Debug.Log("Tiger OnEnble");
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }

    private void Update()
    {
        health++;

        Debug.Log(health);

        if(health >= 100)
        {
            health = 0;
        }
    }
}

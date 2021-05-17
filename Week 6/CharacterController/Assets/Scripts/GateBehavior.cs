using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Player has entered the trigger zone");
            gameObject.BroadcastMessage("OpenGate");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Player has exited the trigger zone");
            gameObject.BroadcastMessage("CloseGate");
        }
    }

}

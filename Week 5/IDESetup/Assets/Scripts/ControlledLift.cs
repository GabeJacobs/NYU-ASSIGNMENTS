using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlledLift : MonoBehaviour
{
    // Start is called before the first frame update
    private
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartOscilator() {
        gameObject.GetComponent<Oscillator>().restartWithDirection(Vector3.back);
    }
}

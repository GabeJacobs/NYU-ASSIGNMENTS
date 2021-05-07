using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Rotator : MonoBehaviour {

    [Header("Rotation Controls")]
    [Tooltip("speed with which the gameObject is rotating. Measures in degrees/frame")]
    [SerializeField] private float angle = 1f;
    [Tooltip("the axis in which the gameObject is rotating around")]
    [SerializeField] private Vector3 rotationAxis = Vector3.up;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, angle);
    }
}

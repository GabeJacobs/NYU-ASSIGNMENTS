using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

    [Header("Movement Parameters")]
    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;

    [Header("Movement Positions")]
    public Vector3 startingPosition;
    public Vector3 posEnd;
    public Vector3 negEnd;

    private Vector3 direction;
    
    // Start is called before the first frame update
    void Start() {

        //direction of movement;
        direction = movementAxis.normalized;
        
        //precompute positions
        var position = transform.position;
        startingPosition = position;
        posEnd = position + (direction * movementDistance);
        negEnd = position - (direction * movementDistance);
        


    }

    // Update is called once per frame
    void FixedUpdate() {
        
        
        //if we reach the bounds of the movement, reverse
        if (Vector3.Distance(transform.position, posEnd) < 0.01f ||
            Vector3.Distance(transform.position, negEnd) < 0.01f) {
            direction *= -1;
        }
        // move the platform
        transform.Translate(direction * (movementSpeed * Time.deltaTime));

    }
}

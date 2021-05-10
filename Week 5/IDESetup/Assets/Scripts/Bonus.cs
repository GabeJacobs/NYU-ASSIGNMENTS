using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour {

    public int counter;
    public GameObject bonusObject;
    // Start is called before the first frame update
    void Start() {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        Debug.Log(counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup() {
        counter--;
        Debug.Log(counter + " are left");
        if (counter == 0) {
            Debug.Log("spawn bonus");
            SpawnBonus();
        }
            
    }

    void SpawnBonus() {
        GameObject.Instantiate(bonusObject, transform);
    }
}

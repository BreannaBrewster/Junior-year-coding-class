using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody rb;
    [SerializeField]
    int speed = 10;
    // Use this for initialization
    void Start () {
        ////console writes
        //Debug.Log("Failed");
        ////toggles gravity
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500*time.DeltaTime);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,-speed);
        }
}
    
}

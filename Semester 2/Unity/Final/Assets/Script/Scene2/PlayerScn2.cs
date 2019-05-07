using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScn2 : MonoBehaviour
{

    public Rigidbody rb;
    [SerializeField]
    int speed = 10;
    // Use this for initialization
    void Start()
    {
        ////console writes
        //Debug.Log("Failed");
        ////toggles gravity
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500*time.DeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > 121.9 && transform.position.z <140 && transform.position.x < -9)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
        else if (transform.position.z < 137.5 && transform.position.z > 60 && transform.position.x > -9)
        {
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
        else if (transform.position.z < 60 && transform.position.x > -67&& transform.position.x< 15)
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
        if (transform.position.z > 45 && transform.position.x < -65)
        {
            if (Input.GetKey(KeyCode.W))
            {
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
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
    }
}
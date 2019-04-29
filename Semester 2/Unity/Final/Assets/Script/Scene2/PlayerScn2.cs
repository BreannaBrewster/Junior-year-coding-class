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
        //if (transform.position.x < -5.7)
        //{
        //    if (Input.GetKey(KeyCode.A))
        //    {
        //        rb.AddForce(0, 0, speed);
        //    }
        //    if (Input.GetKey(KeyCode.D))
        //    {
        //        rb.AddForce(speed, 0, 0);
        //    }
        //    if (Input.GetKey(KeyCode.S))
        //    {
        //        rb.AddForce(-speed, 0, 0);
        //    }
        //    if (Input.GetKey(KeyCode.W))
        //    {
        //        rb.AddForce(0, 0, -speed);
        //    }
        //}
        //if (transform.position.z < 56.6)
        //{
        //    if (Input.GetKey(KeyCode.A))
        //    {
        //        rb.AddForce(0, 0, speed);
        //    }
        //    if (Input.GetKey(KeyCode.W))
        //    {
        //        rb.AddForce(speed, 0, 0);
        //    }
        //    if (Input.GetKey(KeyCode.S))
        //    {
        //        rb.AddForce(-speed, 0, 0);
        //    }
        //    if (Input.GetKey(KeyCode.D))
        //    {
        //        rb.AddForce(0, 0, -speed);
        //    }
        //}
        if (transform.position.x > -73.5)
        {
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
        //if (transform.position.z > 125.3)
        //{
        //    if (Input.GetKey(KeyCode.A))
        //    {
        //        rb.AddForce(0, 0, speed);
        //    }
        //    if (Input.GetKey(KeyCode.W))
        //    {
        //        rb.AddForce(speed, 0, 0);
        //    }
        //    if (Input.GetKey(KeyCode.S))
        //    {
        //        rb.AddForce(-speed, 0, 0);
        //    }
        //    if (Input.GetKey(KeyCode.D))
        //    {
        //        rb.AddForce(0, 0, -speed);
        //    }
        //}
    }
}
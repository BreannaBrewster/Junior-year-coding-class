using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Scn2 : MonoBehaviour {
    public Rigidbody rb;
    [SerializeField]
    int speed = 10;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update() {
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
        if (transform.position.z > 121.9 && transform.position.x > -88.5)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
        if (transform.position.z < 137.5 && transform.position.z > 45 && transform.position.x > -13.7)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
    }
}

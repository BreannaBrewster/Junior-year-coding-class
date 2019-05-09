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
        if (transform.position.z > 121.9 && transform.position.z < 140 && transform.position.x < -9)
        {
            if (Input.GetKey(KeyCode.RightArrow))
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
        else if (transform.position.z < 137.5 && transform.position.z > 60 && transform.position.x > -9)
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
        else if (transform.position.z < 60 && transform.position.x > -67 && transform.position.x < 15)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
        if (transform.position.z > 45 && transform.position.x < -65)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(0, 0, -speed);
            }
        }
    }
}

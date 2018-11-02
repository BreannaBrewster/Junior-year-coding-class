﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;

    float jump = 50;
    float speed = 10;
    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        velocity = rbody.velocity;

		if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            velocity += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            velocity = Vector3.up * jump;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
        }
        if(!Input.GetKeyDown(KeyCode.LeftArrow) &&  !Input.GetKeyDown(KeyCode.RightArrow))
        {
            velocity -= velocity * Time.deltaTime;
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f));
        //velocity = new Vector3(0,0,0);
        
    }
    
}

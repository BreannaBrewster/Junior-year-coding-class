using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Vector3 velocity = new Vector3(0, 0, 20);
    float speed = 10;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
        velocity = new Vector3(0, 0, -5);
        velocity.Normalize();
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -5)
        {
            transform.position += new Vector3(Random.Range(0, 6), 0, -5) * Time.deltaTime * speed;
        }
        if(transform.position.x > 5)
        {
            transform.position += new Vector3(Random.Range(-5, 1), 0, -5) * Time.deltaTime * speed;
        }
        else
        {
            transform.position += new Vector3(Random.Range(-5, 6), 0, -5) * Time.deltaTime * speed;
        }
    }
}

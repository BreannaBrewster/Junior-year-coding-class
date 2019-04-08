using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Vector3 velocity = new Vector3(0, 0, 20);
    int speed = 10;
    float deathTime;
    public Rigidbody rb;
    Random rand = new Random();
    // Use this for initialization
    void Start () {
        velocity = new Vector3(0, 0, -5);
        velocity.Normalize();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(Random.Range(-5,6),0,-5) * Time.deltaTime * speed;
        deathTime += Time.deltaTime;
        if(deathTime >5)
        {
            Destroy(gameObject);
        }
    }
}

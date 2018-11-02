using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflower : MonoBehaviour {
    [SerializeField]
    GameObject ballPrefab;
    float speed = 2f;
    float jump = 2f;

    Vector3 velocity = new Vector3(0, 0, 0); 
    Rigidbody2D rbody;
    GameObject SunflowerPrefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.D))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity += Vector3.up * jump;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            velocity += Vector3.down * speed * Time.deltaTime;
        }
    }
}

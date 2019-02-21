using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    [SerializeField]
    
    float speed = 2f;

    public Vector3 velocity = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start () {
        velocity = new Vector3(-0.2f, 0, 0);
        velocity.Normalize();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += velocity * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }
        Destroy(gameObject);
    }
}

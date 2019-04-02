using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


        public Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;
    // Use this for initialization
    [SerializeField]
    float speed = 5f;
    void Start()
    {
        velocity = new Vector3(Random.RandomRange(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
        transform.position = new Vector3(0, 0, 0);
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += velocity * Time.deltaTime * speed;
        if (transform.position.x < -6.55)
        {
            transform.position = new Vector3(0, 0, 0);
            velocity = new Vector3(1, Random.Range(-1f, 1f), 0);
        }
        if (transform.position.x > 6.55)
        {
            transform.position = new Vector3(0, transform.position.y, 0);
            velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        }
        if (transform.position.y > 4.7)
        {
            
            velocity = Vector3.Reflect(velocity, Vector3.down);
            transform.position = new Vector3(transform.position.x, 4.7f, 0);
        }
        if (transform.position.y < -4.86)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, -4.86f, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        velocity = Vector3.Reflect(velocity, Vector3.right);
    }
}


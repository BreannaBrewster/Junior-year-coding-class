using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public Vector3 velocity = new Vector3(0, 0, 0);
    // Use this for initialization
    [SerializeField]
    public float timer = 0.0f;
    float speed = 2f;
    void Start()
    {
        velocity = new Vector3(Random.RandomRange(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            velocity = new Vector3(0, 0, 1);
        }
        if (transform.position.x < -8.77)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(-8.77f, transform.position.y, 0);
        }
        if (transform.position.x > 8.75)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(8.75f, transform.position.y, 0);
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
}

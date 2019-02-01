using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    Rigidbody2D rbody;
    [SerializeField]
    float speed = 10;

    Vector3 velocity = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rbody.velocity;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.y < 3.97)
            {
                velocity += Vector3.up * speed * Time.deltaTime;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(transform.position.y > -3.97)
                {
                velocity += Vector3.down * speed * Time.deltaTime;
            }
        }
        velocity.Normalize();
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f));
    }
}

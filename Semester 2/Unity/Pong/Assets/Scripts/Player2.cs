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
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4)
        {
            transform.position += .5f * Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow)&& transform.position.y > -4)
        {
            transform.position += .5f * Vector3.down * Time.deltaTime * speed;
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f));
    }
}

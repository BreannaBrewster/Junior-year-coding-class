using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //GetComponent<SpriteRenderer>.color
    }
    [SerializeField]
    GameObject ballPrefab;
    float speed = 2f;

    Vector3 velocity = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
        }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject newBall = Instantiate(ballPrefab);
                newBall.transform.position = transform.position;
            newBall.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z);
        }
        velocity.Normalize();
        transform.position += velocity * speed * Time.deltaTime;
    }
    void Movement()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 4.7)
            {
                velocity += Vector3.up; //* Time.deltaTime
                //transform.position += speed * Vector3.up * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -8.75)
            {
                velocity += Vector3.left; //* Time.deltaTime;
                //transform.position += speed * Vector3.left * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -4.7)
            {
                velocity += Vector3.down;// * Time.deltaTime;
                //transform.position += speed * Vector3.down * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 8.75)
            {
                velocity += Vector3.right;// * Time.deltaTime;
                                          //transform.position += speed * Vector3.right * Time.deltaTime;
            }
        }


    }
    public Vector3 LookAtDirection(float eulerAngles2)
    {
        return new Vector3(Mathf.Cos(eulerAngles2 * Mathf.Deg2Rad), Mathf.Sin(eulerAngles2 * Mathf.Deg2Rad), 0);
    }
}


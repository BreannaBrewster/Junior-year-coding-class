using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 velocity = new Vector3(0, 0, 0);
    // Use this for initialization
    [SerializeField]
    public float timer = 0.0f;
    float speed = 2f;
    void Start ()
    {
        velocity = new Vector3(Random.RandomRange(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if(timer >= 2)
        {
            //color();
            timer = 0;
        }
        
        transform.position += velocity * Time.deltaTime * speed;
        if (transform.position.x < -8.77)
        {
            color();
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(-8.77f, transform.position.y, 0);
        }
        if (transform.position.x > 8.75)
        {
            color();
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(8.75f, transform.position.y, 0);
        }
        if (transform.position.y > 4.7)
        {
            color();
            velocity = Vector3.Reflect(velocity, Vector3.down);
            transform.position = new Vector3(transform.position.x, 4.7f,0);
        }
        if (transform.position.y < -4.86)
        {
            color();
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, -4.86f, 0);
        }
    }
    public void color()
    {
        GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f);
    }
}

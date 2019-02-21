using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    // Use this for initialization
    public Vector3 velocity = new Vector3(0, 0, 0);
    // Use this for initialization
    [SerializeField]
    public float timer = 0.0f;
    float speed = 2f;
    void Start()
    {
        velocity = new Vector3(0.5f,0, 0);
        velocity.Normalize();

    }

    // Update is called once per frame
    void Update () {
        transform.position += velocity * Time.deltaTime * speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        if (col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
        }
        Destroy(gameObject);
    }
}

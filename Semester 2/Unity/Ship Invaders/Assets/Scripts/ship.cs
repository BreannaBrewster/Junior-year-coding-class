using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {

    // Use this for initialization
    public float timer = 0.0f;
    [SerializeField]
    GameObject bulletPrefab;
    float speed = 2f;

    Vector3 velocity = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        speed = speed * 1.1f;
        timer += Time.deltaTime;
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 0)
            {
                transform.position += .5f * Vector3.up * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -9.5f)
            {
                transform.position += .5f * Vector3.left * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -9.5f)
            {
                transform.position += .5f * Vector3.down * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < -8)
            {
                transform.position += .5f * Vector3.right * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (timer >= .5)
            {
                timer = 0;
                GameObject newBullet = Instantiate(bulletPrefab);
                newBullet.transform.position = transform.position;
                newBullet.GetComponent<Bullet>().velocity = .5f * Vector3.right * Time.deltaTime * speed;
            }
        }
        velocity.Normalize();
        transform.position += velocity * speed * Time.deltaTime;
    }
}

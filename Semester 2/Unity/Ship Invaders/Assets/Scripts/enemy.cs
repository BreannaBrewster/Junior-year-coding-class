using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    [SerializeField]
    GameObject bulletPrefab;
    float speed = 2f;
    public float timer = 0.0f;
    public Vector3 velocity = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start () {
        velocity = new Vector3(-0.2f, 0, 0);
        velocity.Normalize();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        speed = speed * 1.001f;
        transform.position += velocity * Time.deltaTime * speed;
        if (timer >= .5)
        {
            timer = 0;
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = transform.position;
            newBullet.GetComponent<Bullet>().velocity = .5f * Vector3.right * Time.deltaTime * speed;
        }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle : MonoBehaviour {
    float speed = 4;
    Vector3 velocity = new Vector3(1, 0, 0);
    Vector3 p, localScale;
    Rigidbody2D rbody;
    // Use this for initialization
    public List<Vector3> teleportLocation = new List<Vector3>();
    // Use this for initialization
    public GameObject hazard;
    public Transform[] spawnPoints;
    
    [SerializeField]
    float timer = 0.0f;
    float spawnTime = 3;
    float amount = 0.5f;
    void Start()
    {
        localScale = transform.localScale;
        velocity = new Vector3(Random.RandomRange(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        p = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(hazard, spawnPoints[teleportLocation.Count].position, spawnPoints[teleportLocation.Count].rotation);
        if (transform.position.x>=0 && transform.position.x <-25)
        {
            teleport();
        }
    }
    public void teleport()
    {
        transform.position = teleportLocation[Random.Range(0, teleportLocation.Count)];

    }
    void MoveRight()
    {
        p += transform.right * Time.deltaTime * speed;
        transform.position = p + transform.up * Mathf.Sin(Time.time * spawnTime) * amount;
    }
}

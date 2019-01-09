using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;
    public List<Vector3> teleportLocation = new List<Vector3>();
    GameObject SunPrefab;
    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody2D>();
        velocity -= Vector3.down;
    }
	
	// Update is called once per frame
	void Update ()
    {
        rbody.velocity = new Vector3(0, 0, Mathf.Clamp(Time.time, 6.0f, 7.0f));
        if (transform.position.y > -3.26)
        {
            velocity -= Vector3.down;
        }
        else
        {
            fallTeleport();
        }

        rbody.velocity = new Vector3(0, 0, Mathf.Clamp(Time.time, 6.0f, 7.0f));
    }
    public void fallTeleport()
    {
        transform.position = teleportLocation[Random.Range(0, teleportLocation.Count)];
        
    }
}

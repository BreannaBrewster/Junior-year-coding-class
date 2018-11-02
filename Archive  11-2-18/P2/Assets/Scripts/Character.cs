using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float jump = 2;
    float speed = 4;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;
    // Use this for initialization
    public List<Vector3> teleportLocation = new List<Vector3>();
    void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.G))
        {
            GameManager.Instance.Character = this;
        }
        velocity = rbody.velocity;
		if(Input.GetKeyDown(KeyCode.W))
        {
            velocity += Vector3.up * jump;
            SoundManager.Instance.PlayOneShot(SoundEffect.Jump);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
        }
        if(!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime), velocity.y, 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f));
    }
    public void clickTeleport()
    {
        transform.position = teleportLocation[Random.Range(0, teleportLocation.Count)];
    }
}

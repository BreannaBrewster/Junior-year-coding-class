using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScn2 : MonoBehaviour {
    public Vector3 playerLocation;
    public GameObject player;
    private Vector3 offset;

    public int turn=1;
    public float degree;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        playerLocation = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 rotation = transform.eulerAngles;
        transform.position = player.transform.position + offset;
        playerLocation = player.transform.position;
        if (playerLocation.x > -11 && playerLocation.z > 122)
        {
            if (turn == 1)
            {
                if(this.gameObject.name == "Main Camera1")
                {
                    transform.position = new Vector3(playerLocation.x+15, transform.position.y, transform.position.z);
                }
                transform.position = new Vector3(playerLocation.x, transform.position.y, transform.position.z + 5);
                offset = transform.position - player.transform.position;
                rotation.y = 180;
                rotation.z = -9;
                transform.eulerAngles = rotation;
                turn++;
            }
        }
        if (playerLocation.z < 60 && playerLocation.x <3)
        {
            if (turn== 2)
            {
                transform.position = new Vector3(transform.position.x + 11, transform.position.y, transform.position.z - 5);
                offset = transform.position - player.transform.position;
                rotation.y = -95;
                rotation.z = -9;
                transform.eulerAngles = rotation;
                turn++;
            }
        }
        if (playerLocation.x < -66 && playerLocation.z >45 && playerLocation.z < 63)
        {
            if(turn ==3)
            {
                //transform.Rotate(Vector3.up, 90);
                transform.position = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
                offset = transform.position - player.transform.position;
                rotation.y = 0;
                rotation.z = 0;
                transform.eulerAngles = rotation;
                turn++;
            }
        }
        else if (playerLocation.z > 122 && playerLocation.x > -73)
        {
            if (turn == 4)
            {
                //transform.Rotate(Vector3.up, 90);
                transform.position = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
                offset = transform.position - player.transform.position;
                rotation.y = 90;
                rotation.z = 0;
                transform.eulerAngles = rotation;
                turn = 1;
            }
        }

    }
}

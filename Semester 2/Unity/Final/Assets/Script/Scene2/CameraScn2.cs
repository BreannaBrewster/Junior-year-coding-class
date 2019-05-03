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
            if (turn%2 != 0 && turn%3 !=0)
            {
                transform.position = new Vector3(playerLocation.x, transform.position.y, transform.position.z + 5);
                offset = transform.position - player.transform.position;
                rotation.y = 170;
                rotation.z = -9;
                transform.eulerAngles = rotation;
                turn++;
            }
        }
        if (playerLocation.z < 60 && playerLocation.x <3)
        {
            if (turn % 2 == 0)
            {
                transform.position = new Vector3(transform.position.x + 11, transform.position.y, transform.position.z - 5);
                offset = transform.position - player.transform.position;
                rotation.y = -95;
                rotation.z = -9;
                transform.eulerAngles = rotation;
                turn++;
            }
        }
        //else if(playerLookingAt.x < -68.7)
        //{
        //    transform.RotateAround(Vector3.up, player.transform.position.y - 89.8f);
        //}
        //else if(playerLookingAt.z > 125.3)
        //{
        //    transform.RotateAround(Vector3.up, player.transform.position.y - 89.8f);
        //}

    }
}

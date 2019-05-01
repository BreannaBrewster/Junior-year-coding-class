using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScn2 : MonoBehaviour {
    public Vector3 playerLocation;
    public GameObject player;
    private Vector3 offset;

    public int turn=0;
    public float degree;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        playerLocation = player.transform.position + transform.position;
        
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 rotation = transform.eulerAngles;
        transform.position = player.transform.position + offset;
        playerLocation = player.transform.position + transform.position;
        if (playerLocation.x > -10.7 && playerLocation.z > 122.9)
        {
            if (turn == 0)
            {
                //if (this.gameObject.name == "Main Camera2")
                //{
                //    this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 40);
                //}
                //rotation.y = 180;
                //transform.eulerAngles = rotation;
                transform.Rotate(Vector3.up, 30);
                turn =1;
            }
        }
        //if (playerLookingAt.z< 56.6&&playerLookingAt.z> 140.1&& playerLookingAt.x > -10.8)
        //{
        //    transform.RotateAround(Vector3.up, player.transform.position.y - 89.8f);
        //}
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

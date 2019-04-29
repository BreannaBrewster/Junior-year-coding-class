using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScn2 : MonoBehaviour {
    public Vector3 playerLookingAt;
    public GameObject player;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        playerLookingAt = player.transform.position + transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
        playerLookingAt = player.transform.position + transform.position;
        //if(playerLookingAt.x > -5.7)
        //{
        //    transform.RotateAround(Vector3.up, player.transform.position.y - 89.8f);
        //}
        if(playerLookingAt.z< 56.6&&playerLookingAt.z> 122.6&& playerLookingAt.x > -10.8)
        {
            transform.RotateAround(Vector3.up, player.transform.position.y - 89.8f);
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

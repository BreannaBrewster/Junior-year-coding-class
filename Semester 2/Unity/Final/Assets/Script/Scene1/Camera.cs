using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    private float C2Offset;
    private Vector3 rotateValue;
    private int rotateTimes = 0;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        if (this.gameObject.name == "Camera")
        {
            C2Offset = transform.position.z - player.transform.position.z;
        }  
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.name == "Main Camera")
        {
            transform.position = player.transform.position + offset;
            if (player.transform.position.y < -8.8 && rotateTimes == 0)
            {
                rotateTimes++;
                gameObject.transform.position = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z + 3);
                offset = transform.position - player.transform.position;
                transform.Rotate(Vector3.up, player.transform.position.y - 89.8f);
            }
        }
        else if(this.gameObject.name == "Camera")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,player.transform.position.z);//player.transform.position + C2Offset;
        }

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

    public Sprite Left, Right, Up, Down;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<SpriteRenderer>().sprite = Right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<SpriteRenderer>().sprite = Left;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<SpriteRenderer>().sprite = Up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<SpriteRenderer>().sprite = Down;
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player" && col.gameObject.name != "Restart Catch Block")
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(col.gameObject.tag == "Cover")
        {
            Destroy(this.gameObject);
        }
        if(col.gameObject.name == "Change Scene1")
        {
            SceneManager.LoadScene("Scene2");
        }
        if(col.gameObject.name == "Restart Catch Block")
        {
            col.transform.position = new Vector3(-69, 47, 133);
        }
    }
}

using System.Collections;
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
        if(col.gameObject.tag == "Player")
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(col.gameObject.name == "cover")
        {
            Destroy(this.gameObject);
        }
    }
}

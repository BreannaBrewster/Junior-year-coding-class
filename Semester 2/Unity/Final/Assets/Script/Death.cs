using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    float deathTime;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        deathTime += Time.deltaTime;
        if (deathTime > 5)
        {
            Destroy(this.gameObject);
        }
    }
}

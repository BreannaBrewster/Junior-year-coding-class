using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public float spawnTime = 2;
    public GameObject Enemy;
    //public List<Vector3> spawnPoints = new List<Vector3>();
    [SerializeField]
    float speed = 2f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
        spawnTime += spawnTime * .8f;
    }
    void Spawn()
    {
        GameObject newEnemy = Instantiate(Enemy);
        newEnemy.transform.position = new Vector3(0, 1.2f, 50.76f);
        newEnemy.GetComponent<Enemy>().velocity = new Vector3(-0.2f, 0, 0);
    }

}

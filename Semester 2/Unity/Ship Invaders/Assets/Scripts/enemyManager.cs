using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameObject enemy1;
public class enemyManager : MonoBehaviour {
    public float spawnTime;
    public GameObject Enemy;
    float speed = 2f;
    public List<Vector3> spawnPoints = new List<Vector3>();
    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}

    // Update is called once per frame
    private void Update()
    {
        spawnTime += spawnTime * .75f;
    }
    void Spawn () {
        GameObject newEnemy1 = Instantiate(Enemy);
        newEnemy1.transform.position = spawnPoints[Random.Range(0, spawnPoints.Count)];
        newEnemy1.GetComponent<enemy>().velocity = new Vector3(-0.2f, 0, 0);//.5f * Vector3.right * Time.deltaTime * speed;

    }
}

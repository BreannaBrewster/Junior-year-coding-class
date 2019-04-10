using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float spawnTime = 2;
    public GameObject Enemy;
    //public List<Vector3> spawnPoints = new List<Vector3>();
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime * .9f, spawnTime * .9f);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime > spawnTime * .000001)
        {
            spawnTime = spawnTime * .99999f;
        }
    }
    void Spawn()
    {
        GameObject newEnemy = Instantiate(Enemy);
        newEnemy.transform.position = new Vector3(0, 1.2f, 50.76f);
        newEnemy.GetComponent<Enemy>().velocity = new Vector3(-0.2f, 0, 0);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.gameObject.transform.position = new Vector3(9, -10.52f, 35.492f);
        }
    }
}

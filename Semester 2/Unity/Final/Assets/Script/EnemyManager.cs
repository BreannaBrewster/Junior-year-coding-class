using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float timer = 40;
    public float spawnTime = 2;
    public GameObject Enemy;
    Vector3 enemySpawn = new Vector3(0, 1.2f, 50.76f);
    Vector3 enemyVelocity = new Vector3(-0.2f, 0, 0);
    //public List<Vector3> spawnPoints = new List<Vector3>();
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime * .9f, spawnTime * .9f);
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer > 100)
        {
            if (spawnTime > spawnTime * .000001)
            {
                spawnTime = spawnTime * .99999f;
            }
        }
    }
    void Spawn()
    {
        GameObject newEnemy = Instantiate(Enemy);
        newEnemy.transform.position = enemySpawn;
        newEnemy.GetComponent<Enemy>().velocity = enemyVelocity;
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.gameObject.transform.position = new Vector3(8.92f, -10.57f, 52.24f);
            this.transform.localScale = new Vector3(3, 2, 15);
            timer = -100000000;
            enemyVelocity = new Vector3(0, 0, 0.2f);
            enemySpawn = new Vector3(6.91f, -8.83f, 52.53f);
            spawnTime = 2;
        }
    }
}

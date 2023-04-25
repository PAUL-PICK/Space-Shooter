using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] Transform[] spawnPoint;
    [SerializeField] float startDelay = 1.0f;
    [SerializeField] float spawnInterval = 0.9f;
    private bool gamePlaying = true;
    // Start is called before the first frame update
    void Start() {
        //calls the named method() on repeat
        InvokeRepeating("EnemySpawner",startDelay,spawnInterval);
        
    }

    // Update is called once per frame
    void Update() {
      //  EnemySpawner();
    }

    private void EnemySpawner() {
        if(gamePlaying==true) {
            int randomEnemy = Random.Range(0,enemyPrefabs.Length);
            int randomSpawnPoint = Random.Range(0,spawnPoint.Length);

            Instantiate(enemyPrefabs[randomEnemy],spawnPoint[randomSpawnPoint].position,transform.rotation);

            }
        }
}

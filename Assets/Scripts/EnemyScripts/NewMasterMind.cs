using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewMasterMind : MonoBehaviour
{
    [SerializeField] GameObject missilePrefab;
    Vector3 playerPosition;
    [SerializeField] float spawnTime = 5f;
    int currentEnemies;
    [SerializeField] int maxEnemies = 6;

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        StartCoroutine(enemyWave());
    }
    private void SpawnEnemy(GameObject whatToSpawn)
    {
        if (maxEnemies >= currentEnemies)
        {
            if (playerPosition.x != 0)
            {
                GameObject a = Instantiate(whatToSpawn) as GameObject;
                if (playerPosition.x > 0)
                {
                    a.transform.position = new Vector3(-30, 20, 0);
                    a.transform.Rotate(0, 0, 90);
                }
                else if (playerPosition.x < 0)
                {
                    a.transform.position = new Vector3(30, 20, 0);
                    a.transform.Rotate(0, 0, 270);
                }
            }
        }
    }
    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            currentEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
            playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            SpawnEnemy(missilePrefab);
        }
    }
}

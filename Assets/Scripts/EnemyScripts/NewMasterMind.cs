using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewMasterMind : MonoBehaviour
{
    [SerializeField] GameObject missilePrefab;
    Vector3 playerPosition;
    [SerializeField] float spawnTime = 5f;

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        StartCoroutine(enemyWave());
    }
    private void SpawnEnemy(GameObject whatToSpawn)
    {
        GameObject a = Instantiate(whatToSpawn) as GameObject;
        if(playerPosition.x < 0)
        {
            a.transform.position = new Vector2(-30, 20);
        }
        else if(playerPosition.x > 0)
        {
            a.transform.position = new Vector2(-30, -20);
        }
    }
    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnEnemy(missilePrefab);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterMind : MonoBehaviour
{
    [SerializeField] int maxEnemiesAllowed = 4;
    [SerializeField] float spawnDelay = 2f;
    [SerializeField] float coolDown = 0;

    [SerializeField] Transform spawningPositionR;
    [SerializeField] Transform spawningPositionL;

    [SerializeField] GameObject missile; //QUESTION: is there a better method of getting these gameobjects?
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //PROBLEM: this code is not working as intended
        if (GameObject.FindGameObjectsWithTag("Enemy").Length > maxEnemiesAllowed)
        {
            coolDown += Time.deltaTime;
            //when coolDown is equeal or greater then spawnDelay and the player is on the right spawn a missile on the right
            if (player.transform.position.x < 1 && coolDown >= spawnDelay)
            {
                SpawnEnemies(missile, true);
                Debug.Log("missile spoted");
            }
            //when coolDown is equeal or greater then spawnDelay and the player is on the left spawn a missile on the left
            if (player.transform.position.x > -1 && coolDown >= spawnDelay) 
            {
                SpawnEnemies(missile, false);
                Debug.Log("Missile spoted");
            }
        }
        
    }
    void SpawnEnemies(GameObject currentEnemy, bool isSpawningOnLeftPosition)
    {
        if (isSpawningOnLeftPosition)
        {
            Instantiate(currentEnemy, new Vector3(-30, 20, 0), Quaternion.identity); //spawns an enemy att the given position att the original rotation
            Debug.Log("Missile spoted");

        }

        else
        {
            Instantiate(currentEnemy, new Vector3(30, 20, 0), Quaternion.identity);
            Debug.Log("Missile spoted");
        }
    }
}

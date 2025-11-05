using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to an object to begin spawning enemies

public class EnemySpawner : MonoBehaviour
{
    //Pos for spawner and bool to check if spawn
    private Vector3 pos;
    private bool spawn;

    private PrefabDetection scriptA;

    //Enemy prefab assigned to object and how many to spawn
    public GameObject enemyPrefab;
    public int numOfEnemiesToSpawn;


    void Start()
    {
        pos = gameObject.transform.position;
        spawn = true;
        spawnEnemyPrefab();
    }

    //Get and Set methods for pos of spawner
    public Vector3 Position
    {
        get { return pos; }
        set { pos = value; }
    }
    
    public void setEnemyPrefab(int i)
    {
        scriptA.getObject(i);
    }


    //simple bool check to see if spawning
    //Change spawn bool to begin or stop testing
    public bool Spawn
    {
        get { return spawn; }
        set { spawn = value; }
    }


    //spawns the enemy prefab/GameObject for the num of enemies bool
    public void spawnEnemyPrefab()
    {
        for(int i = 0; i < numOfEnemiesToSpawn; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab) as GameObject;
            newEnemy.transform.position = pos;
            newEnemy.SetActive(true);
            Debug.Log("I have created a new enemy!");
        }
        
    }

}

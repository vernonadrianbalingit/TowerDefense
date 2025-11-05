using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerPlacement : MonoBehaviour
{
   //Array of tower locations
    private GameObject[] towerSpawns;
    public GameObject towerPrefab;
    
    void Start()
    {
        
        //Creates array of locations to spawn
        if (towerSpawns == null)
        {
            Debug.Log("Making spawn location");
            towerSpawns = GameObject.FindGameObjectsWithTag("Tower Location");
        }
        
    }
    
    //method takes a tower spawn location
    public void addTower(GameObject towerSpawn)
    {

        if (towerSpawn.GetComponent<MapTowerLocation>().Occupied)
        {
            Debug.Log("Occupied");
        }

        else
        {
            GameObject towerPlaced = Instantiate(towerPrefab) as GameObject;
            towerPlaced.transform.position = towerSpawn.transform.position;
            towerSpawn.GetComponent<MapTowerLocation>().Occupied = true;
            towerSpawn.GetComponent<MapTowerLocation>().Tower = towerPlaced;
        }
    }


    //method takes a tower spawn location
    public void removeTower(GameObject towerSpawn)
    {

        if (towerSpawn.GetComponent<MapTowerLocation>().Occupied)
        {
            Destroy(towerSpawn.GetComponent<MapTowerLocation>().Tower);
            towerSpawn.GetComponent<MapTowerLocation>().Occupied = false;
        }

        else
        {
            Debug.Log("Open");
        }
    }

    public void checkSpawnLocation()
    {
        //Searches for objects with tower spawn Location tag
        foreach (GameObject towerSpawn in towerSpawns)
        {
            //logs location and if occupied
            Debug.Log(towerSpawn.transform.position);
            Debug.Log(towerSpawn.GetComponent<MapTowerLocation>().Occupied);


            Vector3 up = towerSpawn.transform.TransformDirection(Vector3.up) * 10;


            if (towerSpawn.GetComponent<MapTowerLocation>().Occupied)
            {
                Debug.DrawRay(towerSpawn.transform.position, up, Color.red, 5);
            }

            else
            {
                Debug.DrawRay(towerSpawn.transform.position, up, Color.green, 5);
            }
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTowerLocation : MonoBehaviour
{

    private GameObject[] towerSpawns;
    private GameObject tower;
    private bool full;
    private Vector3 pos;

    public bool Occupied
    {
        get { return full; }
        set { full = value; }
    }

    public Vector3 Position
    {
        get { return pos; }
        set { pos = value; }
    }
    
    public GameObject Tower
    {
        get { return tower; }
        set { tower = value; }
    }

    void Start()
    {
        pos = gameObject.GetComponent<Transform>().position;
        full = false;

        //Creates array of TowerLocations
        if (towerSpawns == null)
        {
            Debug.Log("Making spawn location");
            towerSpawns = GameObject.FindGameObjectsWithTag("Tower Location");
        }
    }

}

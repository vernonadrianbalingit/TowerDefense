using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    public int towerLevel;
    private int maxTowerLevel = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //get the tower level
    public int getTowerLevel()
    {
        return towerLevel;
    }

    //set the tower level
    public void setTowerLevel(int level)
    {
        int newLevel = level;
        if (level > maxTowerLevel)
        {
            newLevel = maxTowerLevel;
        }
        towerLevel = newLevel;

        Debug.Log("Tower Level set");
    }



    //levels the tower up by 1
    public void towerLevelUp()
    {
        if(towerLevel + 1 > maxTowerLevel)
        {
            towerLevel = maxTowerLevel;
            Debug.Log("tower level is maxed at: " + maxTowerLevel);
        } else
        {
            towerLevel += 1;
            Debug.Log("Tower level up by 1");
        }
    }

    //levels the tower down by 1
    public void towerLevelDown()
    {
        if (towerLevel - 1 < 1)
        {
            towerLevel = 1;
            Debug.Log("Tower Level at min of 1");
        }
        else
        {
            towerLevel -= 1;
            Debug.Log("Tower level down by 1");
        }
      
    }
}

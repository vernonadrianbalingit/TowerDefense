using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public float totalHealth;
    private bool isAlive;
   // public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHealth(float health)
    {
        totalHealth = health;
    }

    public float getHealth()
    {
        return totalHealth;
    }


    // use this to see if the object is alive
    public void setAlive()
    {
        if(totalHealth <= 0)
        {
            isAlive = false;
            Debug.Log("alive is false");
        }
        else
        {
            isAlive = true;
            Debug.Log("Alive is true");
        }
    }

    public bool getAlive()
    {
        return isAlive;
    }

    //use this to change the health on the object
    public void applyDamage()
    {
        float damage = Bullet.getDamage();
        totalHealth -= damage;
        if(totalHealth < 0)
        {
            totalHealth = 0;
        }
        Debug.Log("damage of " + damage + " applied");
    }
}

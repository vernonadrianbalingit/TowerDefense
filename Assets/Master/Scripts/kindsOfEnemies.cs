using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kindsOfEnemies
{
    private double health;
    private int goldValue;
    private double speed;
    private int enemyType;
    // Start is called before the first frame update

    //Assigns the three enemytypes their values
    void Start()
    {
        if(enemyType == 1)
        {
            enemyOne();
        
        }else if (enemyType == 2)
        {
            enemyTwo();
        
        } else if(enemyType == 3)
            {
            enemyThree();
            }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Assigns unique variables to enemy 1
    public void enemyOne()
    {
        setHealth(100.0);
        setGoldValue(10);
        setSpeed(1.0);
    }
    // Assigns unique variables to enemy 2
    public void enemyTwo()
    {
        setHealth(75.0);
        setGoldValue(15);
        setSpeed(2.0);
    }
    // Assigns unique variables to enemy 3
    public void enemyThree()
    {
        setHealth(250.0);
        setGoldValue(50);
        setSpeed(0.7);
    }

    public void death()
    {
        HealthScript h = new HealthScript();
        bool dead = h.getAlive();
        MoneyOnKill y = new MoneyOnKill();
        if (!dead)
        {
            if (enemyType == 1)
            {
                enemyOne();
                y.addMoney();
            }
            else if (enemyType == 2)
            {
                enemyTwo();
                y.addMoney();
            }
            else if (enemyType == 3)
            {
                enemyThree();
                y.addMoney();
            }
        }
    }




//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void setHealth(double health) => this.health = health;
    public double getHealth() => health;
    public void setGoldValue(int gold) => goldValue = gold;
    public int getGoldValue() => goldValue;
    public void setSpeed(double speed) => this.speed = speed;
    public double getSpeed() => speed;
}

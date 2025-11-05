using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyOnKill
{
    private int needToAddToBallance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        setneedToAddToBallance(0);
    }
    // determines if enemy is killed and how much gold to add to balance if killed
    public void addMoney()
    {
        HealthScript h = new HealthScript();
        bool addMoney = h.getAlive();
        int placeHolder = 0;
        kindsOfEnemies k = new kindsOfEnemies();
        placeHolder = k.getGoldValue();
        setneedToAddToBallance(placeHolder);
    }
    public void setneedToAddToBallance(int money) => money = needToAddToBallance;
    public int getneedToAddToBallance() => needToAddToBallance;

   
}

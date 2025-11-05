using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script
public class shopItem : MonoBehaviour
{
    //local gold variable
    private int gold;
    public int standardTurretPrice;
    public GameObject standardTurret;

    //update local gold variable
    void Update()
    {
        gold = GameManagerBehavior.Gold;
    }
    //check if enough gold to purchase tower
    public void standardTurretSelected()
    {
        if(gold <= standardTurretPrice)
        {
            BuildManager.setTurretToBuild(standardTurret);
            Debug.Log("ready to place");
        }
        else
        {
            Debug.Log("not enough money");
        }
    }
}

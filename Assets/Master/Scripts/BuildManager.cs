using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script
public class BuildManager : MonoBehaviour
{
    //build manager that sets the type of turrent that is going to be built
    public GameObject standardTurret;

    //the current turret that is trying to be placed
    private static GameObject turretToBuild;

    public static GameObject getTurretToBuild()
    {
        return turretToBuild;
    }

    public static void setTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}

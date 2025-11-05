using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script
public class TowerAiming : MonoBehaviour
{
    //range variable for tower
    public float range;
    //the enemy that the tower is currently targeting
    private Transform target;
    //the tag for the enemy objects
    public string enemyTag;
    //amount of times method will run per a second
    public float updaterTime;
    //how many times the turret shoots per a second
    public float fireRate;
    private float fireCountdown = 0f;
    //object being used as the bullet
    public GameObject bulletPrefab;
    //the place where the bullet spawns so it does not spawn inside of the turret
    public Transform firePoint;
    //this is the transform that rotates to look at the target so the whole tower is not rotating
    public Transform rotator;
    //this is the amount of damage the tower will deal
    public float damage;
    void Start()
    {
        //helps optimize the game by running target updater every "updaterTime" amount of times per a second
        InvokeRepeating("TargetUpdater", 0f, 1 / updaterTime);
    }

    private void Update()
    {
        if(target == null)
        {
            return;
        }
        //this rotates the rotator part of the tower so it is aiming at the target
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = lookRotation.eulerAngles;
        rotator.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        //calls the shoot method the number of times of the fire rate per a second
        if(fireCountdown <= 0f)
        {
            shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
    }

    void shoot()
    {
        GameObject bulletGameObject = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGameObject.GetComponent<Bullet>();

        if(bullet != null)
        {
            bullet.setTarget(target);
            bullet.setDamage(damage);
        }
    }
    //TargetUpdater loops through all enemies and finds which enemy is closest to the tower, and if it is in the tower's range
    void TargetUpdater()
    {
        //array of all enemies
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        //temp variables for for loop
        float closestEnemyDistance = Mathf.Infinity;
        GameObject closestEnemyObject = null;

        //loops through all enemies find enemy closest to tower
        for (int i = 0; i < enemies.Length; i++)
        {
            float distanceOfCurrentEnemy = Vector3.Distance(transform.position, enemies[i].transform.position);
            if (distanceOfCurrentEnemy < closestEnemyDistance)
            {
                closestEnemyDistance = distanceOfCurrentEnemy;
                closestEnemyObject = enemies[i];
            }
        }
        //if closest enemy is in range, set that enemy as the target
        if (closestEnemyDistance <= range)
        {
            target = closestEnemyObject.transform;
        }
        else
        {
            target = null;
        }
        if (target != null)
        {
            Debug.Log("The target's position is: " + target.position);
        }
        else
        {
            Debug.Log("There is not a target");
        }
    }
}
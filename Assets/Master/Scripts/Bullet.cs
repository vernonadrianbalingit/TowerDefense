using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    // Update is called once per frame
    public float speed;
    //this is the amount of damage the bullet deals
    private static float damage;
    //the three functions bellow are all setter and getter methods for the target and damage
    public void setTarget(Transform _target)
    {
        target = _target;
    }
    public void setDamage(float _damage)
    {
        damage = _damage;
    }
    public static float getDamage()
    {
        return damage;
    }
    void Update()
    {
        //destroys bullet if the target is lost
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        //aims the bullet
        Vector3 direction = target.position - transform.position;
        //how fast the bullet travels
        float distanceTraveled = speed * Time.deltaTime;

        //calls a function if the target is hit
        if(direction.magnitude <= distanceTraveled)
        {
            targetHit();
            return;
        }

        //moves the bullet
        transform.Translate(direction.normalized * distanceTraveled, Space.World);
    }
    //destroys bullet when it hits the target
    void targetHit()
    {
        Destroy(gameObject);
    }
}

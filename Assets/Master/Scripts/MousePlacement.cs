using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePlacement : MonoBehaviour
{
    //will use this script when working with deleting and placing towers in order to be more accurate
    
    //Check if mouse clicks on object 
    Ray ray;
    RaycastHit hit;

    //script needed for method testing
    public TowerPlacement scripta;
    

    void Update()
    {

        //cast a ray from the main camera to mouse pos
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //middle mouse button pressed
        if (Input.GetMouseButtonDown(2))
            scripta.checkSpawnLocation();


        if(Physics.Raycast(ray, out hit))
        {
            //right click pressed
            if (Input.GetMouseButtonDown(1))
            {

                if(hit.collider.tag == "Tower Location")
                {
                    Debug.Log(hit.collider.name);
                    scripta.addTower(hit.collider.gameObject);
                }
                
            }

            //left click pressed
            else if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.tag == "Tower Location")
                {
                    Debug.Log(hit.collider.name);
                    scripta.removeTower(hit.collider.gameObject);
                }
            }
        }

        
    }
}

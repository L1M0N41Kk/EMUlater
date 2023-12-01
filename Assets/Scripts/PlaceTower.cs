using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject towerPrefab;
    public GameObject towerPrefab2;
    public GameObject towerPrefab3;
    public GameObject towerPrefab4;


    public GameObject towerInstance;
    public Transform pointOfTowerSpawn;
    public bool thisBoxIsEmpty = true;
    public bool canDestroyTower;
    public int index;

    private void Update()
    {
        if(canDestroyTower && !thisBoxIsEmpty && Input.GetKeyDown(KeyCode.Mouse1))
        {
            thisBoxIsEmpty = true;
            Debug.Log("fff");
            Destroy(towerInstance);
        }
    }

    private void OnMouseDown()
    {
        if (!thisBoxIsEmpty)
        {
            this.index++;
            if (index == 0)
            {
                Destroy(this.towerInstance);
                this.towerInstance = Instantiate(towerPrefab, pointOfTowerSpawn.position, Quaternion.identity) as GameObject;
            }
            if (index == 1)
            {
                Destroy(this.towerInstance);
                this.towerInstance = Instantiate(towerPrefab2, pointOfTowerSpawn.position, Quaternion.identity) as GameObject;
            }
            if (index == 2)
            {
                Destroy(this.towerInstance);
                this.towerInstance = Instantiate(towerPrefab3, pointOfTowerSpawn.position, Quaternion.identity) as GameObject;
            }
            if (index == 3)
            {
                Destroy(this.towerInstance);
                this.towerInstance = Instantiate(towerPrefab4, pointOfTowerSpawn.position, Quaternion.identity) as GameObject;
            }
            if (index == 4)
            {
                Destroy(this.towerInstance);
                this.towerInstance = Instantiate(towerPrefab, pointOfTowerSpawn.position, Quaternion.identity) as GameObject;
                index = 0;
            }
        }
        if (thisBoxIsEmpty)
        {
            towerInstance = Instantiate(towerPrefab, pointOfTowerSpawn.position, Quaternion.identity) as GameObject;
            thisBoxIsEmpty = false;
        }
      
    }

    private void OnMouseOver()
    {
        canDestroyTower = true;
        Debug.Log("can destroy");
    }
    private void OnMouseExit()
    {
        canDestroyTower = false;
        Debug.Log("cant destroy");
    }

}

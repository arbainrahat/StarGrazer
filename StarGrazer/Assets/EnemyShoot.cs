using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    //DataFields for Set Time Between the Shoots
    private float timeBtwShots;
    public float startTimeBtwShots;

    //Public gameObject for take bullet object
    public GameObject enemyBullet;

    void Start()
    {
        //Assign the start time btw shoots to timeBtwShots (private field) 
        timeBtwShots = startTimeBtwShots;
    }

    
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(enemyBullet, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= 1;
        }
    }
}

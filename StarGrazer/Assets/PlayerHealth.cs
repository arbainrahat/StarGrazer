using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //Public variable for health value
    public int health;

    //Demage methed will reduce the health of player
    public void Demage(int demage)
    {
        //health value reduce when player hit
        health -= demage;

        //if health zero than player destroy or kill
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

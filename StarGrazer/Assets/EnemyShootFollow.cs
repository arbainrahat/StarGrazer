using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootFollow : MonoBehaviour
{
    //Public Speed Field For Set Moving Speed of Bullet
    public float speed;

    //Public demage variable for how much demage to player
    public int demage=40;

    //Private DataFields For Target GameObject
    private Transform player;
    private Vector3 target;
    void Start()
    {
        //Find the gameObject with the name of "Player" Tag
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //Set the target values according to player position
        target = new Vector3(player.position.x, player.position.y,player.position.z);
    }

    
    void Update()
    {
        //Move the bullet towards player
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //If bullet reached at player position than destroy Itself
        if (transform.position.x == target.x && transform.position.y == target.y && transform.position.z==target.z)
        {
            DestroyProjectile();
        }

        //if bullet not find player in game than bullets destroy ItsSelf after Some Time
        Destroy(gameObject, 12f);
    }
   
    //If bullet collide with player than destroy
    private void OnTriggerEnter(Collider collision)
    {
        //Get the player health component when collide with player
        PlayerHealth health = collision.GetComponent<PlayerHealth>();

        if (health != null)
        {
            health.Demage(demage);
        }

        if (collision.CompareTag("Player"))
        {
            DestroyProjectile();
        }

       
    }

    //Function for destroy bullet
    void DestroyProjectile()
    {
        Destroy(gameObject);

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;
    public Transform target;
    private int wavepointindex = 0;
    public int enemyhealth = 1;
    private bool isDead;
    public Transform GameManager;
    

    void Start()
    {

        // Set target to the first waypoint
        target = waypoint_script.points[0];

    }

    void Update()
    {
        // Move towards the waypoint until you reach it
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        // Once it eaches the waypoint it retrieves the next one
        if (Vector3.Distance(transform.position, target.position) <= 0.5f)
        {
            getnextwaypoint();
        }
        if(enemyhealth <= 0)
        {
            DestroyObject(gameObject);
        }
    }

    // Method for retrieving waypoints
    void getnextwaypoint()
    {
        // If the enemy reaches the end this code will run
        if (wavepointindex >= waypoint_script.points.Length - 1)
        {
            LoseLife(GameManager);
            Destroy(gameObject);
            return;
        }
        // Gets the next waypoint
        wavepointindex++;
        target = waypoint_script.points[wavepointindex];
    }

    public void TakeDamage()
    {
        enemyhealth -= 1;

        if (enemyhealth <= 0 && !isDead)
        {
            Die();
        }
    }
    void Die()
    {
        isDead = true;

        //PlayerStats.Money += worth;
        Destroy(gameObject);
    }
    void LoseLife(Transform GameM)
    {
        GameManager GM = GameM.GetComponent<GameManager>();
        GM.lives -= 1;
    }
}

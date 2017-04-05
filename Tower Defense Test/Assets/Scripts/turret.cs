using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour {

    private Transform target;
    [Header("Turret stats")]
    public float range = 15f;
    public float firerate = 1f;
    private float firecountdown = 0f;
    [Header("Unity setup probably dont touch")]
	public string enemyTag = "Enemy";
    public Transform parttorotate;
    public GameObject bulletprefab;
    public Transform firepoint;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        // Finding all the enemies
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestdistance = Mathf.Infinity;
        GameObject nearestenemy = null;
        // For each enemy we find we want to find the distance to the enemy
        // and see if its shorter than any distance found before
        foreach(GameObject enemy in enemies)
        {
            float distancetoenemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distancetoenemy < shortestdistance)
            {
                shortestdistance = distancetoenemy;
                nearestenemy = enemy;
            }
        }
        //If the nearest enemy isnt null and within the tower range target it
        if (nearestenemy != null && shortestdistance <= range)
        {
            target = nearestenemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if(target == null)
        {
            return;
        }
        // Target lock on
        Vector3 facedirection = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(facedirection);
        Vector3 rotation = Quaternion.Lerp(parttorotate.rotation, lookRotation, Time.deltaTime * 8).eulerAngles;
        parttorotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (firecountdown <= 0f)
        {
            Shoot();
            firecountdown = 1f / firerate;
        }

        firecountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        bullet bullet = bulletGO.GetComponent<bullet>();
        if(bullet != null)
        {
            bullet.seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

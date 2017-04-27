using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemybutton : MonoBehaviour {

    public GameObject enemy;
    public float spawnx = -6.23f;
    public float spawny = 1.5f;
    public float spawnz = 2.7f;
    public void spawningenemy(GameObject spawn)
    {
        Instantiate(enemy, new Vector3(spawnx, spawny, spawnz), Quaternion.identity);
    }
}

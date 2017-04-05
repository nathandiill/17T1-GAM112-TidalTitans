using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemybutton : MonoBehaviour {

    public GameObject enemy;

    public void spawningenemy(GameObject spawn)
    {
        Instantiate(enemy, new Vector3(5, 2, 37), Quaternion.identity);
    }
}

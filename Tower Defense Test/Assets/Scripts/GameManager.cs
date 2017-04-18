using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public int enemycount = 0;
    public bool startingnet = true;
    public float timer = 25;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	//void Update () {
 //       timer -= Time.deltaTime;
 //       if(enemycount == 0 && timer < 0)
 //       {
 //           SceneManager.LoadScene("MainMenu");
 //       }
	//}
}

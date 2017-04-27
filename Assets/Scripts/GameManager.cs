using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public int enemycount = 0;
    public bool startingnet = true;
    public float timer = 25;
    public int lives = 3;

    // Use this for initialization
    void Update()
    {
        if(lives <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}

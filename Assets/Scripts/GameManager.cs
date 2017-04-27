using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int enemycount = 0;
    public bool startingnet = true;
    public float timer = 25;
    public int lives = 3;
    public float costOfTower;
    public Text curText;
    public float Stating_currency;

    // Use this for initialization
    void Update()
    {
        CalcCurrency();
        //costOfTower = towerSelected
        if (lives <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    void CalcCurrency()
    {
        // curText.text = Stating_currency.ToString();
        // costOfTower -= GetComponent<node>().turret.GetComponent<turret>().cost;
    }
}

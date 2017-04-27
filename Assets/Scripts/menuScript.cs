using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    //Load the levels
    public void Level1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Level1");
    }
    public void Level2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Level2");
    }
    public void Level3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Level3");
    }

    //Load the credits level
    public void ClickCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("CreditsScreen");
    }

    //Return to the main menu
    public void ClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("MainMenu");
    }

    //Exit the application
    public void ClickExit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    //Load the main level scene
    public void ClickPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("MainScene");
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
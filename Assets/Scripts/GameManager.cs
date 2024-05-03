using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    void Start()
    {

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {

    }

    public void NewGame()
    {
        SceneManager.LoadScene("levelONE");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

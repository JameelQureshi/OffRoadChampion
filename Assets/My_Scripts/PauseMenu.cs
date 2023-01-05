using LevelUnlockSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject[] levels;
    public GameObject OpenedLevel;

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }   
    
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }   
    
    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("HomeScreen");
    }   
    

}

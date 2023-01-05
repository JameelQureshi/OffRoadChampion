using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamepause : MonoBehaviour
{
    //private Main_manu_ui pause_screen_active;
    // Start is called before the first frame update
    public GameObject pausegame_screen;
   
    void Start()
    {
        //pause_screen_active = GameObject.Find("main_manu_camera").GetComponent<main_manu_camera>
        //pausegame_screen.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void PauseGame()
    //{

    //    pausegame_screen.SetActive(true);


    //}
     public void pausegame_button()
    {
        Time.timeScale = 0;
        pausegame_screen.SetActive(true);
    }
      public   void ResumeGame()
    {
        Time.timeScale = 1;
        pausegame_screen.SetActive(false);
     
    }
    public void restart_game()
    {
        Time.timeScale = 1;
        pausegame_screen.SetActive(false);
        SceneManager.LoadScene("level1");
    }
    public void homeScreen()
    {
        Time.timeScale = 1;
        pausegame_screen.SetActive(false);
        SceneManager.LoadScene("Garage_A_SI");
    }
}

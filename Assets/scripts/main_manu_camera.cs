using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main_manu_camera : MonoBehaviour
{
    public GameObject mainmanucamera;
    public GameObject bus_selection_camera;
    public GameObject mainmanuUI;
    public GameObject shopmanu;
    public GameObject loading_screen;
    public GameObject exit_screen;
    public GameObject leve_chose_sc;
  
    
    //public GameObject pause_screen;
    // Start is called before the first frame update
 

    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mainmanucamera()
    {
        mainmanucamera.SetActive(true);
        mainmanuUI.SetActive(true);
        shopmanu.SetActive(false);
        bus_selection_camera.SetActive(false);
        //loading_screen.SetActive(false);
        exit_screen.SetActive(false);
        //pause_screen.SetActive(false);
    }
    public void shopmanucamera()
    {
        mainmanucamera.SetActive(false);
        mainmanuUI.SetActive(false);
        shopmanu.SetActive(true);
        bus_selection_camera.SetActive(true);
        
        //loading_screen.SetActive(false);
        exit_screen.SetActive(false);
        leve_chose_sc.SetActive(false);

        //pause_screen.SetActive(false);
    }
    public void on_loading_screen()
    {
        mainmanucamera.SetActive(false);
        mainmanuUI.SetActive(false);
        //bus_selection_camera.SetActive(true);
        shopmanu.SetActive(true);
        //bus_selection_camera.SetActive(true);
        loading_screen.SetActive(true);
        exit_screen.SetActive(false);
        //pause_screen.SetActive(false);
    }
    public void exitscreen()
    {
        mainmanucamera.SetActive(false);
        mainmanuUI.SetActive(false);
        bus_selection_camera.SetActive(true);
        shopmanu.SetActive(true);
        bus_selection_camera.SetActive(true);
        loading_screen.SetActive(false);
        exit_screen.SetActive(true);
        //pause_screen.SetActive(false);
    }
    public void stayonmainmanu()
    {
        mainmanucamera.SetActive(true);
        mainmanuUI.SetActive(true);
        shopmanu.SetActive(false);
        bus_selection_camera.SetActive(false);
        loading_screen.SetActive(false);
        exit_screen.SetActive(false);
        //pause_screen.SetActive(false);
    }
    //public  void pause_game()
    //{
    //    mainmanucamera.SetActive(true);
    //    mainmanuUI.SetActive(false);
    //    shopmanu.SetActive(false);
    //    bus_selection_camera.SetActive(false);
    //    loading_screen.SetActive(false);
    //    exit_screen.SetActive(false);
    //    pause_game_.SetActive(true);
    //}
    public void leve_chose_screen()
    {
        mainmanucamera.SetActive(true);
        mainmanuUI.SetActive(false);
        shopmanu.SetActive(false);
        bus_selection_camera.SetActive(false);
        loading_screen.SetActive(false);
        exit_screen.SetActive(false);
        //pause_screen.SetActive(false);
        leve_chose_sc.SetActive(true);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
    //public void playGame()
    //{
    //    SceneManager.LoadScene("level1");

    //}
}

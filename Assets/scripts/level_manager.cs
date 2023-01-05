using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level_manager : MonoBehaviour
{
    public int lll;
    int LevelUnlocked;
    public static level_manager instance;
    public int LevelPlayed;
    //public Button[] buttons;
    public GameObject[] Butons;
    public int currentlevel;
    public GameObject loading_screen;
    public GameObject level;
    public static int button_click_level;
    
    // Start is called before the first frame update
    private void Start()

    {
        instance = this;
        

        ///////////////////////////
        //This is how you set and get the level;
        //Copy this and paste this where your level gets completed

        //int LevelplayeD = PlayerPrefs.GetInt("LevelPlayed");
        //LevelplayeD++;
        //PlayerPrefs.SetInt("LevelPlayed", LevelplayeD);

        /////////////////////////////////////////////////

        LevelPlayed = PlayerPrefs.GetInt("LevelPlayed");
        Debug.Log("the value of " + LevelPlayed);
      Butons=  GameObject.FindGameObjectsWithTag("Buttons");
        for (int i = 0; i < LevelPlayed; i++)
        {
            Butons[i].transform.GetChild(1).gameObject.SetActive(false);
        }
        /*for(int i=0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }*/
        //buttons[level_clear.instance.currentlevel + 1].interactable = true;
        Debug.Log("buttons disabled");
        
    }
    void Update()
    {
       
       

      /*  for (int i = 0; i < LevelUnlocked; i++)
        {*/
          
           


       // }
        //disableall();
        //if (!PlayerPrefs.HasKey("LevelClearedCount"))
        //    PlayerPrefs.SetInt("LevelClearedCount",0);
        //int clearlevel = PlayerPrefs.GetInt("LevelClearedCount");
        //Debug.Log(clearlevel); 
        //for (int i = 0; i<clearlevel+1; ++i)
        //{
        //    transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        //}

    }

    // Update is called once per frame
  
    public void loadlevel(int levelindex)
    {
        //Debug.Log("hello");
        //level.SetActive(false);
        
        loading_screen.SetActive(true);
        Debug.Log("bilal");
        lll = levelindex;
        
        StartCoroutine(call());



        /*SceneManager.LoadScene(levelindex)*/
        ;
        //Debug.Log(levelindex + "bilal");


       
    }
    IEnumerator call()
    {
        yield return new WaitForSeconds(4);
        
        SceneManager.LoadScene(lll);


    }
    //public void disableall()
    //{
    //    int levelButtoncount = transform.childCount;
    //    Debug.Log(levelButtoncount);
    //    for(int i=1; i< levelButtoncount; ++i)
    //    {
    //        transform.GetChild(i).GetComponent<Button>().interactable = false;
    //    }
    //}
    //public void Playerlevel(int level = 0)
    //{
    //    SceneManager.LoadScene(level);
    //}
    public void levels1()
    {
        Debug.Log("You are in level 1");
        button_click_level = 0;
    }
    public void levels2()
    {
        Debug.Log("You are in level 2");
        button_click_level = 1;
    }
    public void levels3()
    {
        Debug.Log("You are in level 3");
        button_click_level = 2;
    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class level_clear : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
//        if(PlayerPrefs.HasKey("LevelCleared"))
//        {

//        }
//        else
//        {
//            PlayerPrefs.SetInt("LevelCleared", 0);
//                if(PlayerPrefs.HasKey("LevelClearedCount"))
//            {

//            }
//            else
//            {
//                PlayerPrefs.SetInt("LevelClearedCount",0);
//            }
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//    public void LevelCleared()
//    {
//        int previousbuilIndex = PlayerPrefs.GetInt("LevelCleared");
//        Debug.Log(previousbuilIndex);
//        int currentbuildIndex = SceneManager.GetActiveScene().buildIndex;
//        Debug.Log(currentbuildIndex);
//        int previouslevelCount = PlayerPrefs.GetInt("LevelClearedCount");
//        Debug.Log(previouslevelCount);
//        if (currentbuildIndex > previousbuilIndex)
//        {
//            PlayerPrefs.SetInt("LevelCleared", SceneManager.GetActiveScene().buildIndex);
//            PlayerPrefs.SetInt("LevelClearedCount", previouslevelCount + 1);
//        }
//         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//    }

//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_clear : MonoBehaviour
{

    public static level_clear instance;
    public int currentlevel;


    public void Start()
    {
        instance = this;
    }
    public void pass()
    {
         currentlevel = SceneManager.GetActiveScene().buildIndex;
        if(currentlevel >= PlayerPrefs.GetInt("LevelUnlocked"))
        {
            PlayerPrefs.SetInt("LevelUnlocked", currentlevel + 1);
            StartCoroutine(waitme());
            
        }
        Debug.Log("Level" + PlayerPrefs.GetInt("LevelUnlocked")+"UNLOCKED");
        IEnumerator waitme()
        {
            yield return new WaitForSeconds(10);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        
    }
}


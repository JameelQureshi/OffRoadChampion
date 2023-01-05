using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void PlayScene()
    {
        SceneManager.LoadScene("Level_1_Environment_1");
    }
}

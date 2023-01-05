using LevelUnlockSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject[] levels;
    public static LevelSelect instance;

    public void Start()
    {
        Instantiate(levels[LevelSystemManager.Instance.CurrentLevel]);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public GameObject[] buttons;
    public Sprite locked;
    public Sprite[] unlocked, played;
    // Start is called before the first frame update
    void Start()
    {
        //0 is for locked and 1 is for unlocked
        buttons[0].GetComponent<Image>().sprite = unlocked[0];
        PlayerPrefs.SetInt("Locked" + 0, 1);
        for (int i = 1; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Image>().sprite = locked;
            PlayerPrefs.SetInt("Locked" + i, 0);
            PlayerPrefs.SetInt("PLayed" + i, 0);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

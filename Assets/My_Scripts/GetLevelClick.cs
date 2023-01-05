using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLevelClick : MonoBehaviour
{
    bool isClicked = false;
    public static GetLevelClick instance;
    public GameObject playButton;
    private void Awake()
    {
        instance = this;
    }

    public void GetButtonClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            playButton.SetActive(true);
        }
    }
}

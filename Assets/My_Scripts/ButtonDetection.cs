using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetection : MonoBehaviour
{
    public int index;
    
    public void ButtonIndex(int ind)
    {
        index = ind;
        PlayerPrefs.SetInt("Index", index);
    }

}

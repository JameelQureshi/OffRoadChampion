using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLevelSelection : MonoBehaviour
{
    public static EnableLevelSelection instance;
    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void EnableSelection()
    {
        panel.SetActive(true);
    }
}

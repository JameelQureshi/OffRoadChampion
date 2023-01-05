using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class leveltester : MonoBehaviour
{
    public int level;
    public GameObject im;
    void Update()
    {
        if (level <= level_clear.instance.currentlevel + 1)
        {
            //im.transform.GetChild(0).GetComponent<Image>().enabled = true;
            //im.transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
    }
}

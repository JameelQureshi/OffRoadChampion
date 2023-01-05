using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cash_manager : MonoBehaviour
{
    public Text cash_amount;
    public int currentcash = 0;
    void Start()
    {

       
        if (PlayerPrefs.HasKey("Cash"))
        {

            currentcash = PlayerPrefs.GetInt("Cash");
        }
        else
        {

        }
        cash_amount.text = ":" + currentcash;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            currentcash += 100;
            PlayerPrefs.SetInt("Cash", currentcash);
           
           
        }
    }

}


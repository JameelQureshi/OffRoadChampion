using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public GameObject coin;
    int coinsCount = 0;
    public int totalCoins = 0;
    public Transform[] coinTransforms;
    public GameObject GreenLine;
    public GameObject RedLine;
    public GameObject collider;
    //public bool star3;
    public static CollectCoins instance;
    public bool allCoinsCollected;
    public void Start()
    {
        instance = this;
        collider.SetActive(false);
        GreenLine.SetActive(false);
        RedLine.SetActive(true);
        totalCoins = coinTransforms.Length;
        print("total coins " + totalCoins);
        
        Instantiate(coin, coinTransforms[coinsCount].position, Quaternion.identity);
        allCoinsCollected = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("COIN"))
        {
            if(coinsCount < totalCoins)
            {
                coinsCount++;
                print(coinsCount);
                Destroy(other.gameObject);

                PlayerPrefs.SetInt("GoldCoins", coinsCount);

                if(coinsCount <= totalCoins - 1)
                {
                    Instantiate(coin, coinTransforms[coinsCount].transform.position, Quaternion.identity);
                }
            }

            if(coinsCount == totalCoins)
            {
                collider.SetActive(true);
                RedLine.SetActive(false);
                GreenLine.SetActive(true);
                allCoinsCollected = true;
            }
        }
    }
}

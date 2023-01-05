using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shop_manager : MonoBehaviour
{
    public int currentbus_index;
    public GameObject ObjectParent;
    public GameObject[] busModels;
    public unlock_bus_price[] busses;
    public Button buybutton;
    public Image image;
    
    void Start()
    {

        foreach (unlock_bus_price bus in busses)
        {
            if (bus.price == 0)
                bus.isunlocked = true;
            else
                bus.isunlocked = PlayerPrefs.GetInt(bus.name, 0) == 0 ? false : true;
        }



        for (int i = 0; i < busModels.Length; i++)
        {
          GameObject G=  Instantiate(busModels[i], new Vector3(0.11f, 3f, 4f), Quaternion.identity);
            G.transform.SetParent(ObjectParent.transform);
            G.GetComponent<Rigidbody>().isKinematic = true;
            G.GetComponent<RCC_CarControllerV3>().enabled = false;
            
            
            
        }
      

        PlayerPrefs.SetInt("SelectedBus", 0);
        currentbus_index = PlayerPrefs.GetInt("SelectedBus" , 0);
        //Debug.Log(currentbus_index);
        foreach (GameObject bus in busModels)

        {
            bus.SetActive(false);
            busModels[currentbus_index].SetActive(true);
        }
       

    }
    void Update()
    {
        updateUI();
    }
    public void changeNext()
    {
        for (int i = 0; i < ObjectParent.transform.childCount; i++)
        {
            ObjectParent.transform.GetChild(i).gameObject.SetActive(false);
           
        }

        if (currentbus_index==3)
        {
            currentbus_index = 0;

        }

        else 
        { currentbus_index++; }
        ObjectParent.transform.GetChild(currentbus_index).gameObject.SetActive(true);
        Debug.Log(currentbus_index);
        unlock_bus_price b = busses[currentbus_index];
        Debug.Log(b);
        if (!b.isunlocked)
            return;



        PlayerPrefs.SetInt("SelectedBus", currentbus_index);
        //unlock_bus_price b = busses[currentbus_index];
        //if (!b.isunlocked)
        //    return;
    }
    public void changeprevoius()
    {
        for (int i = 0; i < ObjectParent.transform.childCount; i++)
        {
            ObjectParent.transform.GetChild(i).gameObject.SetActive(false);
        }

        if (currentbus_index == 0)
        {
            currentbus_index = 3;


        }
        else
        { currentbus_index--; }
        ObjectParent.transform.GetChild(currentbus_index).gameObject.SetActive(true);
        unlock_bus_price b = busses[currentbus_index];
        if (!b.isunlocked)
            return;


        PlayerPrefs.SetInt("SelectedBus", currentbus_index);
        //unlock_bus_price b = busses[currentbus_index];
        //if (!b.isunlocked)
        //    return;

        ////busModels[currentbus_index].SetActive(false);
        ////currentbus_index--;
        //if (currentbus_index == 3)
        //{
        //    currentbus_index = 0;
        //}
        //else
        //{
        //    currentbus_index--;
        //}
        // ObjectParent.transform.GetChild(currentbus_index).gameObject.SetActive(false);

        ////busModels[currentbus_index].SetActive(true);
        //PlayerPrefs.SetInt("SelectedBus", currentbus_index);
    }
    //public void playGame()
    //{
    //    SceneManager.LoadScene("level1");
    //}

    // Update is called once per frame
    void updateUI()
    {
        unlock_bus_price b = busses[currentbus_index];
        if (b.isunlocked)
        {
            buybutton.gameObject.SetActive(false);
            image.gameObject.SetActive(false);

        }
        else
        {
            image.gameObject.SetActive(true);
            buybutton.gameObject.SetActive(true);
            buybutton.GetComponentInChildren<Text>().text = "" + b.price;
            if (b.price < PlayerPrefs.GetInt("Cash", 0))

            {
                buybutton.interactable = true;
            }
            else
            {
                buybutton.interactable = false;
            }
        }
    }
    public void Unlockbus()
    {
        unlock_bus_price b = busses[currentbus_index];
        PlayerPrefs.SetInt(b.name, 1);
        PlayerPrefs.SetInt("SelectedBus", currentbus_index);
        b.isunlocked = true;
        Debug.Log(currentbus_index);
        PlayerPrefs.SetInt("Cash", PlayerPrefs.GetInt("Cash", 0) - b.price);
    }
    


}

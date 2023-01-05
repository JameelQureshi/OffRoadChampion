using LevelUnlockSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCalculator : MonoBehaviour
{
    public float startTime;
    public float currentTime;
    public static TimeCalculator Instance;
    public int count = 0;
    private GameObject timeText;
    bool isComplete = false;
    // Start is called before the first frame update
    public static TimeCalculator instance;
    void Start()
    {
        startTime = 0;
        timeText = GameObject.Find("timeText"); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Green_Collider"))
        {
            isComplete = true;
            currentTime = Time.time - startTime;
            count += 1;

            if (currentTime < 120 && startTime > 90)
            {
                count += 1;
            }

            if (currentTime < 120 && startTime < 90)
            {
                count += 1;
            }
            print("count " + count);
            print("current Time " + currentTime);

            GameUI.instance.GameOver(count);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    // Update is called once per frame
    void Update()
    {
        if(isComplete == false)
        {
            startTime = Time.time;
            float roundedValue = Mathf.Round(startTime * 100f) / 100f;
            DisplayTime(roundedValue);
        }
    }
}

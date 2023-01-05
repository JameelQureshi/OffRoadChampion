using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConfettiEffect : MonoBehaviour
{
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject cam;
    public GameObject cam2,Refcam;
    public bool CameraAnimTrue;
    public GameObject LevelCompletionPanel;
    public GameObject RccCanvas;
    private void Start()
    {
        cam2 = GameObject.FindGameObjectWithTag("MainCamera");
        cam = GameObject.FindGameObjectWithTag("Cam");
        Refcam = GameObject.FindGameObjectWithTag("Ref");
       
        cam.SetActive(false);
        Refcam.SetActive(false);

        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        LevelCompletionPanel = GameObject.Find("LevelCompletePanel");
        RccCanvas = GameObject.FindGameObjectWithTag("RCCCanvas");
        RccCanvas.SetActive(true);/*
        LevelCompletionPanel.SetActive(false);*/
    }
    public void Update()
    {
        if (CameraAnimTrue==true)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, Refcam.transform.position,0.1f);
            cam.transform.rotation = Refcam.transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Green_Collider"))
        {
            particle1.SetActive(true);
            particle2.SetActive(true);
            particle3.SetActive(true);
            particle4.SetActive(true);
            cam.transform.position = cam2.transform.position;
            cam.transform.rotation = cam2.transform.rotation;
            cam2.transform.parent.gameObject.SetActive(false);
            cam.SetActive(true);
            StartCoroutine(StopsPlayer());
            CameraAnimTrue = true;
            LevelCompletionPanel.SetActive(true);
            RccCanvas.SetActive(false);
        }
    }
    
    IEnumerator StopsPlayer()
    {
        yield return new WaitForSeconds(3f);
        //player.GetComponent<RCC_CarControllerV3>().enabled = false;
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
    }

}

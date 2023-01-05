using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    [SerializeField]
    private GameObject targetGameObject;
    private int count;
    // public GameObject Arrow;
    private void Start()
    {
    }

    void Update()
    {
        if (CollectCoins.instance.allCoinsCollected == false)
        {
            targetGameObject = GameObject.FindGameObjectWithTag("COIN");
            targetGameObject.GetComponent<ParticleSystem>().enableEmission = true;
        }
        else
            targetGameObject = GameObject.FindGameObjectWithTag("FinishLine");

       Vector3 trans = new Vector3(targetGameObject.transform.position.x, transform.position.y,targetGameObject.transform.position.z);
        transform.LookAt(trans);
    }
}

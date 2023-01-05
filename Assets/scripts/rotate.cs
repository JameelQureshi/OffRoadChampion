using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //public GameObject rotate1;
    [SerializeField] GameObject rotation_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(rotation_ * Time.deltaTime);
        //    StartCoroutine(roratedelay());
        //rotate1.transform.Rotate(0, 0, Time.deltaTime * 10f);
    }
    //IEnumerator  roratedelay()
    //{
    //    yield return new WaitForSeconds(10);
    //    transform.Rotate(rotation_ * Time.deltaTime);
    //}
}

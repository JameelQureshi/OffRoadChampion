using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_bus_index_placement : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentbus_index;
    public GameObject[] sceneruningbus;
    //public bl_MiniMap miniMap;
    public  GameObject bilal;
    public static scene_bus_index_placement instance;

    //public GameObject parentobject;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        //for(int i =0; i<sceneruningbus.Length; i++)
        //{
        //    GameObject g = Instantiate(sceneruningbus[i], new Vector3(0, 0, 0), Quaternion.identity);
        //    g.transform.SetParent(parentobject.transform);
        //}
      
        currentbus_index = PlayerPrefs.GetInt("SelectedBus", 0);
        foreach (GameObject bus in sceneruningbus)
        {
            bus.SetActive(false);
            sceneruningbus[currentbus_index].SetActive(true);
        }

       // miniMap.Target = sceneruningbus[currentbus_index].transform;

        bilal = sceneruningbus[currentbus_index].GetComponent<Rigidbody>().gameObject;
    }
}

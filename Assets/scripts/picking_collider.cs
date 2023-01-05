using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picking_collider : MonoBehaviour
{
    //public string PlayerTag = "Player";
    //public static int index = 0;
    //public GameObject particle;
    //public int levelcount;
    ////public GameObject Cubeprefab;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    //Instantiate(particle, new Vector3(0, 0, 0), Quaternion.identity);
    //    levelcount = PlayerPrefs.GetInt("LevelPlayed");
    //    if (levelcount == 0)
    //    {

    //        Debug.Log("I am In level 1");
    //        level1();
    //    }
    //    if (levelcount == 1)
    //    {
    //        level2();
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //void OnTriggerEnter(Collider c)
    //{
    //    if (c.CompareTag(PlayerTag) && levelcount == 0)
    //    {
    //        //Debug.Log("first index");

    //        ////Destroy(gameObject);
    //        //levelcount++;
    //        //Debug.Log(index + " index value");
    //        level1trigger();
    //    }


    //    else if (c.CompareTag(PlayerTag) && levelcount == 1)
    //    {
    //        //Destroy(gameObject);

    //        //Debug.Log("hy");
    //        //Instantiate(particle, new Vector3(0, 0, 0), Quaternion.identity);
    //        ////Destroy(gameObject);
    //        ///
    //        level2trigger();
    //    }
    //}
    //public void level1()
    //{
    //    //Instantiate(Cubeprefab, new Vector3(150, 5, -116), Quaternion.identity);

    //}
    //public void level2()
    //{
    //    GameObject g = GameObject.FindGameObjectWithTag("bilal");
    //    g.SetActive(false);
    //    Debug.Log(g + "++++++++++++++++++=");
    //}
    //public void level1trigger()
    //{
    //    if (index == 0)
    //    {
    //        //Destroy(gameObject);
    //        Instantiate(particle, new Vector3(150, 1.5f, -87), Quaternion.identity);
    //        index++;
    //    }
    //    else if (index == 1)
    //    {
    //        Instantiate(particle, new Vector3(160, 1.5f, -87), Quaternion.identity);
    //    }
    //}
    //public void level2trigger()
    //{
    //    if (index == 0)
    //    {
    //        Destroy(gameObject);
    //        Instantiate(particle, new Vector3(0, 0, 0), Quaternion.identity);
    //        Instantiate(particle, new Vector3(100, 0, 0), Quaternion.identity);
    //        Instantiate(particle, new Vector3(300, 0, 0), Quaternion.identity);
    //        index++;
    //    }
    //    else if (index == 1)
    //    {
    //        Instantiate(particle, new Vector3(500, 0, 100), Quaternion.identity);
    //    }
    //}
    public GameObject chrachter_parent;
    public GameObject cubes;
    public GameObject[] character;
    public static picking_collider instance;
    public int levelcount;
    public Vector3[] position_;
    public GameObject final_collider;
    public GameObject final_collider_1;
    public GameObject final_collider_2;
    public GameObject final_collider_3;
    public GameObject[] barriers;
    public Vector3[] barriers_position;
    public GameObject[] Bus_Holder;
    public Vector3[] level2_barrior_position;
    public Vector3[] cubes_collider_position;
    public Vector3[] level3_barrior_position;
    public GameObject[] droppersons;
    public GameObject Instruction_screen;
    public GameObject particles;
    public GameObject Particle_parent;
    public Vector3[] particles_position;

    
    
    

    private void Start()
    {
        Debug.Log(level_manager.button_click_level + "value");
        instance = this;
        
        
        levelcount = PlayerPrefs.GetInt("LevelPlayed");
        if(level_manager.button_click_level == 0)
        {
            Bus_Holder[0].SetActive(true);
            Bus_Holder[1].SetActive(false);
            Bus_Holder[2].SetActive(false);
            Bus_Holder[3].SetActive(false);

            level1();
            Debug.Log(level_manager.button_click_level + "jsbhsdbsjhb");
            for (int i = 0; i < barriers.Length; i++)
            {
                Instantiate(barriers[i], barriers_position[i], transform.rotation);
            }
        }
        else if(level_manager.button_click_level == 1)
        {
            Debug.Log("You are in level 2");
            Bus_Holder[0].SetActive(false);
            Bus_Holder[1].SetActive(true);
            Bus_Holder[2].SetActive(false);
            Bus_Holder[3].SetActive(false);
            for (int i = 0; i < level2_barrior_position.Length; i++)
            {
                Instantiate(barriers[i], level2_barrior_position[i], transform.rotation);
            }
            level2();
        }
        else if (level_manager.button_click_level == 2)
        {
            Debug.Log("You are in level 3");
            Bus_Holder[0].SetActive(false);
            Bus_Holder[1].SetActive(false);
            Bus_Holder[2].SetActive(true);
            Bus_Holder[3].SetActive(false);
            for (int i = 0; i < level3_barrior_position.Length; i++)
            {
                Instantiate(barriers[i], level3_barrior_position[i], transform.rotation);
            }
            level3();
        }

    }
    
    public void level1()

    {
        //Instantiate(character, new Vector3(142, 1.5f, -58), Quaternion.identity);
        //Instantiate(cubes, new Vector3(138, 1.5f, -58), Quaternion.identity);
        //Instantiate(cubes, new Vector3(138, 1.5f, -65), Quaternion.identity);
        //Instantiate(cubes, new Vector3(138, 1.5f, -73), Quaternion.identity);
        for (int i = 0; i < 2; i++)
        {
            GameObject particle_ = Instantiate(particles, particles_position[i], Quaternion.identity);
            particle_.transform.SetParent(Particle_parent.transform);
        }
        for (int i = 1; i < 2; i++)
        {
            Particle_parent.transform.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 0; i < 1; i++)
        {
            Instantiate(cubes,  cubes_collider_position[i]  , Quaternion.identity);
           
        }
        
        for (int i = 0; i < 1; i++)
        {

            GameObject G = Instantiate(character[i], position_[i], Quaternion.identity);
            G.transform.SetParent(chrachter_parent.transform);
            //character[i].gameObject.SetActive(false);
        }

        //for (int i = 1; i < 3; i++)
        //{
        //    chrachter_parent.transform.GetChild(i).gameObject.SetActive(false);
        //}
    }
   public void level2()
    {
        for (int i = 1; i < 3; i++)
        {
            Instantiate(cubes, cubes_collider_position[i], Quaternion.identity);


        }
        for (int i = 1; i < 3; i++)
        {

            GameObject G = Instantiate(character[i], position_[i], Quaternion.identity);
            G.transform.SetParent(chrachter_parent.transform);
            //character[i].gameObject.SetActive(false);
        }
        for (int i = 1; i < 2; i++)
        {
            chrachter_parent.transform.GetChild(i).gameObject.SetActive(false);
        }

    }
    public void level3()
    {
        for (int i = 3; i < 5; i++)
        {
            Instantiate(cubes, cubes_collider_position[i], Quaternion.identity);
            Debug.Log("hhhhhhhhhhhhhhhhhhhhhhhhh");

            
        }
        for (int i = 3; i < 5; i++)
        {

            GameObject G = Instantiate(character[i], position_[i], Quaternion.identity);
            G.transform.SetParent(chrachter_parent.transform);
            //character[i].gameObject.SetActive(false);
        }
        for (int i = 1; i < 2; i++)
        {
            chrachter_parent.transform.GetChild(i).gameObject.SetActive(false);
        }

        
    }
    public void instructio_screen_off()
    {
        Instruction_screen.SetActive(false);
        scene_bus_index_placement.instance.bilal.GetComponent<Rigidbody>().isKinematic = false;

    }
    
}

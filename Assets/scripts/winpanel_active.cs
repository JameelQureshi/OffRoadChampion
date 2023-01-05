using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winpanel_active : MonoBehaviour
{
    public GameObject winpanel;
    private GameObject bus;
    public GameObject map;
    public GameObject[] drop_persons;
    //public Text cash_amount;
    //public int currentcash = 0;
    // Start is called before the first frame update
    void Start()
    {

        bus = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(bus);
        //    if(PlayerPrefs.HasKey("Cash"))
        //    {
        
        //        currentcash = PlayerPrefs.GetInt("Cash");
        //    }
        //    else
        //    {

        //    }
        //    cash_amount.text = ":" + currentcash;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyUp(KeyCode.X))
        //{
        //    winpanel.SetActive(true);
        //    Time.timeScale = 0;
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && level_manager.button_click_level==0 )
        {
            Destroy( picking_collider.instance.Particle_parent.transform.GetChild(0).gameObject);
            scene_bus_index_placement.instance.bilal.GetComponent<Rigidbody>().isKinematic = true;
            //currentcash += 100;
            //PlayerPrefs.SetInt("Cash", currentcash);


            int LevelplayeD = PlayerPrefs.GetInt("LevelPlayed");
            if (LevelplayeD == 0)
            {
                LevelplayeD++;
                PlayerPrefs.SetInt("LevelPlayed", LevelplayeD);

            }
            map.gameObject.SetActive(false);
            //for(int i=0; i<3; i++)
            //{
                //GameObject G = Instantiate(picking_collider.instance.character[i], picking_collider.instance.position_[i], Quaternion.identity);
                //G.transform.SetParent(chrachter_parent.transform);
                Instantiate(picking_collider.instance.droppersons[0], new Vector3(-658.6373f, 1.5f, 93.83453f), Quaternion.identity);
                //Instantiate(picking_collider.instance.character[1], new Vector3(130, 1.5f, -94), Quaternion.identity);
                //Instantiate(picking_collider.instance.character[2], new Vector3(130, 1.5f, -90), Quaternion.identity);
            //}

            StartCoroutine(winpaneldelay());
            //winpanel.SetActive(true);
            //Time.timeScale = 0;
        }
        if (other.tag == "Player" && level_manager.button_click_level == 1)
        {
            //currentcash += 100;
            //PlayerPrefs.SetInt("Cash", currentcash);
            int LevelplayeD = PlayerPrefs.GetInt("LevelPlayed");
            LevelplayeD++;
            PlayerPrefs.SetInt("LevelPlayed", LevelplayeD);
            map.gameObject.SetActive(false);
            for (int i = 0; i < 3; i++)
            {
                //GameObject G = Instantiate(picking_collider.instance.character[i], picking_collider.instance.position_[i], Quaternion.identity);
                //G.transform.SetParent(chrachter_parent.transform);
                //Instantiate(picking_collider.instance.character[0], new Vector3(-658.6373f, 1.5f, 93.83453f), Quaternion.identity);
                Instantiate(picking_collider.instance.droppersons[1], new Vector3(-243.77f, 1.2f, 489.33f), Quaternion.identity);
                Instantiate(picking_collider.instance.droppersons[2], new Vector3(-246.18f, 1.2f, 489.33f), Quaternion.identity);
            }

            StartCoroutine(winpaneldelay());
            //winpanel.SetActive(true);
            //Time.timeScale = 0;
        }
        if (other.tag == "Player" && level_manager.button_click_level == 2)
        {
            //currentcash += 100;
            //PlayerPrefs.SetInt("Cash", currentcash);
            int LevelplayeD = PlayerPrefs.GetInt("LevelPlayed");
            LevelplayeD++;
            PlayerPrefs.SetInt("LevelPlayed", LevelplayeD);
            map.gameObject.SetActive(false);
            for (int i = 0; i < 3; i++)
            {
                //GameObject G = Instantiate(picking_collider.instance.character[i], picking_collider.instance.position_[i], Quaternion.identity);
                //G.transform.SetParent(chrachter_parent.transform);
                //Instantiate(picking_collider.instance.character[0], new Vector3(-658.6373f, 1.5f, 93.83453f), Quaternion.identity);
                Instantiate(picking_collider.instance.droppersons[3], new Vector3(-429.5656f, 1.5f, -209.831f), Quaternion.identity);
                Instantiate(picking_collider.instance.droppersons[4], new Vector3(-432.27f, 1.5f, -209.831f), Quaternion.identity);
            }

            StartCoroutine(winpaneldelay());
            //winpanel.SetActive(true);
            //Time.timeScale = 0;
        }
    }
    IEnumerator winpaneldelay()
    {
        yield return new WaitForSeconds(5);
        winpanel.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void restart_game()
    {
        Time.timeScale = 1;
        //pausegame_screen.SetActive(false);
        SceneManager.LoadScene("level1");
    }
    public void homeScreen()
    {
        Time.timeScale = 1;
        //pausegame_screen.SetActive(false);
        SceneManager.LoadScene("Garage_A_SI");
    }
}

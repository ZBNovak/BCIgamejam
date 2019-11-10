using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    public int highlightedOption; // This is for storing which item is highlighted
    GameObject mapitem1; // this stores opt 1
    GameObject mapitem2; // opt 2
    GameObject mapitem3; // opt 3
    GameObject mapitem4;


    public void changeHighlight()
    {
        MapLocationScript MLS1 = mapitem1.GetComponent<MapLocationScript>(); // gets all components from mapitem scripts aka HIGHLIGHTED
        MapLocationScript MLS2 = mapitem2.GetComponent<MapLocationScript>();
        MapLocationScript MLS3 = mapitem3.GetComponent<MapLocationScript>();
        MapLocationScript MLS4 = mapitem4.GetComponent<MapLocationScript>();

        MLS1.highlighted1 = false; //sets values to false 
        MLS2.highlighted1 = false;
        MLS3.highlighted1 = false;
        MLS4.highlighted1 = false;

        highlightedOption = Random.Range(1, 5); // Randomly switches which is highlighted (upper limit has to be +1)

        Debug.Log("changed highlight to " + highlightedOption);

        switch (highlightedOption)
        {
            case 1:
                MLS1.highlighted1 = true;
                break;
            case 2:
                MLS2.highlighted1 = true;
                break;
            case 3:
                MLS3.highlighted1 = true;
                break;
            case 4:
                MLS4.highlighted1 = true;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        mapitem1 = GameObject.Find("PBLocation"); //init all game objects and such you want to manipulate
        mapitem2 = GameObject.Find("PBLocation (1)");
        mapitem3 = GameObject.Find("PBLocation (2)");
        mapitem4 = GameObject.Find("PBLocation (3)");
        InvokeRepeating("changeHighlight", 2.0f, 2.0f);

    }

    // Update is called once per frame

    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");

            /*

            if (highlightedOption == 3)
            {
                SceneManager.LoadScene("Jasons Scene", LoadSceneMode.Additive);
            }
            */
        }


    }
}

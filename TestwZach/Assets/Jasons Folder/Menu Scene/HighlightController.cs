using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighlightController : MonoBehaviour
{
    public int highlightedOption; // This is for storing which item is highlighted
    GameObject menuitem1; // this stores opt 1
    GameObject menuitem2; // opt 2
    GameObject menuitem3; // opt 3 

    public void changeHighlight()
    {
        MenuItemsScript MIS1 = menuitem1.GetComponent<MenuItemsScript>(); // gets all components from menuitem scripts aka HIGHLIGHTED
        MenuItemsScript MIS2 = menuitem2.GetComponent<MenuItemsScript>();
        MenuItemsScript MIS3 = menuitem3.GetComponent<MenuItemsScript>();

        MIS1.highlighted = false; //sets values to false 
        MIS2.highlighted = false;
        MIS3.highlighted = false;

        highlightedOption = Random.Range(1, 4); // Randomly switches which is highlighted (upper limit has to be +1)

        Debug.Log("changed highlight to " + highlightedOption);

        switch (highlightedOption){
            case 1:
                MIS1.highlighted = true;
                break;
            case 2:
                MIS2.highlighted = true;
                break;
            case 3:
                MIS3.highlighted = true;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        menuitem1 = GameObject.Find("Pink Brain"); //init all game objects and such you want to manipulate
        menuitem2 = GameObject.Find("Pink Brain (1)");
        menuitem3 = GameObject.Find("Green Brain");
        InvokeRepeating("changeHighlight", 2.0f, 2.0f);

    }

    // Update is called once per frame

    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            if (highlightedOption == 3)
            {
                SceneManager.LoadScene("Map Scene", LoadSceneMode.Single);
            }
        }


    }
}

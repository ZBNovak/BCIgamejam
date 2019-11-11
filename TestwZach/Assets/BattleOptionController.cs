using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleOptionController : MonoBehaviour
{
    public int highlightedOption; // This is for storing which item is highlighted
    private GameObject menuitem1; // this stores opt 1
    private GameObject menuitem2; // opt 2
    private GameObject menuitem3; // opt 3 

    public void changeHighlight() {
        UIController MIS1 = menuitem1.GetComponent<UIController>(); // gets all components from menuitem scripts aka HIGHLIGHTED
        UIController MIS2 = menuitem2.GetComponent<UIController>();
        UIController MIS3 = menuitem3.GetComponent<UIController>();

        MIS1.highlighted = false; //sets values to false 
        MIS2.highlighted = false;
        MIS3.highlighted = false;

        highlightedOption = Random.Range(1, 4); // Randomly switches which is highlighted (upper limit has to be +1)

        Debug.Log("changed highlight to " + highlightedOption);

        switch (highlightedOption) {
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
    void Start() {
        menuitem1 = GameObject.Find("UI_Laser"); //init all game objects and such you want to manipulate
        menuitem2 = GameObject.Find("UI_Missle");
        menuitem3 = GameObject.Find("UI_Shield");
        InvokeRepeating("changeHighlight", 2.0f, 2.0f);

    }

    // Update is called once per frame

    void Update() {

/*
        if (Input.GetKeyDown("space")) {
            print("space key was pressed");
            if (highlightedOption == 3) {
                SceneManager.LoadScene("Map Scene", LoadSceneMode.Single);
            }
        }

    */
    }
}
